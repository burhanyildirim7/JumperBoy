using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class FlyingController : MonoBehaviour
{
    public ParticleSystem ForceJumpParticleSys;

    public Animator CameraAnim;
    public Animator MahkumAnim;
    public Animator Polis1Anim;
    public Animator Polis2Anim;
    //----------------------------------

    private float _tapTapCount = 0f;

    private bool _tapTapControl;

    private bool _forceControl;

    private bool _forceValueControl;

    [SerializeField] private float _yukariFirlatmaKuvveti = 0f;

    [SerializeField] private float _ileriFirlatmaKuvveti = 0f;

    [SerializeField] private float _ikinciYukariFirlatmaKuvveti = 2f;

    [SerializeField] private float _ikinciIleriFirlatmaKuvveti = 2f;

    private float _ikinciYukariZiplamaForce = 0f;
    private float _ikinciIleriZiplamaForce = 0f;


    private float _sliderSonDeger = 0f;


    public Player _player;

    public Trajectory _trajectory;

    [SerializeField]
    Slider slider;

    [SerializeField]
    GameObject sliderObject;

    [SerializeField]
    GameObject TapTapObj;

    public Vector3 _playerForce;

    [SerializeField] private Transform _playerTransform;

    private float _playerYukseklik;

    private bool _ikinciZiplamaKontrol;

    private int _ziplamaSayac = 0;

    private float _sliderBarTimer;

    [SerializeField] private Rigidbody _playerRigidbody;

    float sayac = 0;

    [SerializeField] private GameObject _tapToStartScreen;

    [SerializeField] private GameObject _altBar;

    private bool _oyunBasladi;

    private float _playerKonum;

   

   

    void Start()
    {

        _tapTapControl = false;
        _forceControl = true;
        _forceValueControl = false;
        sliderObject.SetActive(false);
        TapTapObj.SetActive(false);
        _ikinciZiplamaKontrol = false;
        _ziplamaSayac = 0;
        _sliderBarTimer = 0f;
        _oyunBasladi = false;
        _altBar.SetActive(true);
        _tapToStartScreen.SetActive(true);
    }


    void Update()
    {

        _ileriFirlatmaKuvveti = PlayerPrefs.GetFloat("IleriForce");

        _ikinciIleriFirlatmaKuvveti = PlayerPrefs.GetFloat("IkinciIleriForce");

        _playerYukseklik = (int)_playerTransform.position.y;

        if (_tapTapControl == false && _oyunBasladi == true)
        {
            _player.OyunBasiHareket();

            if (_tapTapCount <= 10f && _tapTapCount >= 0.1f)
            {
                _tapTapCount -= Time.deltaTime;
                sayac += Time.deltaTime;
                if (sayac >= 0.5f)
                {
                    if (ForceJumpParticleSys.transform.localScale.y <= 0.8)
                    {
                        ForceJumpParticleSys.transform.localScale = new Vector3(0, 0.8f, 0);
                    }
                    else
                    {
                        ForceJumpParticleSys.transform.localScale -= new Vector3(0, 0.3f, 0);
                    }
                    sayac = 0;
                }



            }
            else
            {

            }

            if (Input.GetMouseButtonDown(0) && _tapTapCount <= 10f)
            {
                _tapTapCount += 1f;
                ForceJumpParticleSys.Emit(1);
                ForceJumpParticleSys.transform.localScale += new Vector3(0, 0.5f, 0);
            }
            else
            {

            }

            if (_tapTapCount >= 10f)
            {
                _tapTapControl = true;
                Debug.Log("Comelme Tamamlandi!");
            }
            else
            {

            }

            Debug.Log(_tapTapCount);
        }

        if (_tapTapControl == true && _forceValueControl == false)
        {
            //Invoke("ForceControl", 1);

            _sliderBarTimer += Time.deltaTime;

            if (_sliderBarTimer >= 1)
            {
                ForceControl();

            }
            else
            {

            }

        }

        if (_tapTapControl == true && _forceControl == false)
        {

            if (Input.GetMouseButtonDown(0))
            {
                _forceControl = true;


                Debug.Log("Son Force Deger = " + slider.value);
                _sliderSonDeger = slider.value;
                sliderObject.SetActive(false);

                FirlatmaGucu();


            }
            else
            {

            }

            /* if (_forceValue <= 3f && _maxForceControl == false)
             {
                 _forceValue += Time.deltaTime;

             }
             else if (_forceValue >= 3f || _forceValue >= 0f)
             {
                 _forceValue -= Time.deltaTime;
                 _maxForceControl = true;

             }
             else if (_forceValue <= 0.1f)
             {
                 _maxForceControl = false;
             }
             else
             {

             }*/

            Debug.Log(slider.value);
        }
        else
        {

        }



        if (_playerYukseklik > 2)
        {
            _ikinciZiplamaKontrol = true;
        }
        else
        {

        }

        if (_ikinciZiplamaKontrol == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_playerYukseklik <= 25 && _ziplamaSayac <= 1)
                {
                    FirlatmaGucuIki();
                    _ziplamaSayac += 1;


                }
                else
                {
                    _ikinciZiplamaKontrol = false;
                }

            }
            else
            {

            }
        }
        else
        {

        }

    }

    public void TapToStartButton()
    {
        CameraAnim.SetBool("TapToStart", true);
        MahkumAnim.SetBool("Run",true);
        Polis1Anim.SetBool("Run", true);
        Polis2Anim.SetBool("Run", true);
        CameraController.TapToStart = true;
        _oyunBasladi = true;
        _altBar.SetActive(false);
        _tapToStartScreen.SetActive(false);
        TapTapObj.SetActive(true);

    }

    private void ForceControl()
    {
        _forceControl = false;
        _forceValueControl = true;
        sliderObject.SetActive(true);
        TapTapObj.SetActive(false);
    }

    private void FirlatmaGucu()
    {
        _yukariFirlatmaKuvveti = _yukariFirlatmaKuvveti * _sliderSonDeger;
        _ileriFirlatmaKuvveti = _ileriFirlatmaKuvveti * _sliderSonDeger;

        _playerForce = new Vector3(0f, _yukariFirlatmaKuvveti, _ileriFirlatmaKuvveti);

        _player.PlayerFirlatma(_playerForce);
        MahkumAnim.SetBool("BirinciZiplama", true);
        _trajectory.UpdateDots(_player.pos, _playerForce);

        _trajectory.Show();
    }

    private void FirlatmaGucuIki()
    {

        _ikinciYukariZiplamaForce = _ikinciYukariFirlatmaKuvveti * _sliderSonDeger;
        _ikinciIleriZiplamaForce = _ikinciIleriFirlatmaKuvveti * _sliderSonDeger;

        _playerForce = new Vector3(0f, _ikinciYukariZiplamaForce, _ikinciIleriZiplamaForce);

        _player.PlayerFirlatmaIki(_playerForce);


        // _trajectory.UpdateDots(_player.pos, _playerForce);

        // _trajectory.Show();
    }
}
