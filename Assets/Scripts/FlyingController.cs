using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class FlyingController : MonoBehaviour
{

    public ParticleSystem ForceJumpParticleSys;
    public GameObject ForceEfect;

    public GameObject ParlamaRing1;
    public GameObject ParlamaRing2;
    public GameObject ParlamaRing3;
    public GameObject ParlamaSpark1;
    public GameObject ParlamaSpark2;
    public GameObject ParlamaObj;

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

    private bool _oyunBasiHareket;
    private bool ForceMaxBool=false;

    float MaxForceSayaci=0;

    public static bool sliderDegerTemp;

    [SerializeField] private CameraShake _cameraShake;

    private int _seciliKarakterNumber;

    void Start()
    {
        ParlamaObj.SetActive(false);
        ForceMaxBool = false;
        ForceEfect.SetActive(false);
        sliderDegerTemp = false;
        //---------------------------

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
        _oyunBasiHareket = false;
    }


    void Update()
    {
        _seciliKarakterNumber = PlayerPrefs.GetInt("SeciliKarakterNumber");


        _ileriFirlatmaKuvveti = PlayerPrefs.GetFloat("IleriForce");

        _yukariFirlatmaKuvveti = PlayerPrefs.GetFloat("YukariForce");

        _ikinciIleriFirlatmaKuvveti = PlayerPrefs.GetFloat("IkinciIleriForce");

        _ikinciYukariFirlatmaKuvveti = PlayerPrefs.GetFloat("IkinciYukariForce");

        _playerYukseklik = (int)_playerTransform.position.y;

        _playerKonum = (int)_playerTransform.position.z;


        //----------------ForceMax
        if (ForceMaxBool==true)
        {
            sliderDegerTemp = true;
            ParlamaObj.SetActive(true);
            MahkumAnim.SetBool("MaxForce", true);
            _cameraShake.ShakeOnce();
            MaxForceSayaci += Time.deltaTime;
            if (MaxForceSayaci >= 3f)
            {
                FirlatmaGucu();
                ForceMaxBool = false;
                ParlamaRing1.SetActive(false);
                ParlamaRing2.SetActive(false);
                ParlamaRing3.SetActive(false);
                ParlamaSpark1.SetActive(false);
            }
            else
            {

            }
        }
        else
        {

        }
        //--------------------------



        if (_oyunBasiHareket == true)
        {
            _player.OyunBasiHareket();
        }
        else
        {

        }

        if (_tapTapControl == false && _oyunBasladi == true && _playerKonum >= 18)
        {
            ForceEfect.SetActive(true);

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
                if (_sliderSonDeger>=11)
                {
                    ForceMaxBool = true;
                }
                else
                {
                    FirlatmaGucu();
                }
            }
            else
            {

            }

            Debug.Log(slider.value);
        }
        else
        {

        }
        //-------------
        //-----------------


        if (_playerRigidbody.velocity.y < 0)
        {
            _ikinciZiplamaKontrol = true;
        }
        else
        {
            _ikinciZiplamaKontrol = false;
        }

        if (_ikinciZiplamaKontrol == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                    FirlatmaGucuIki();
                   
                    MahkumAnim.SetBool("İkinciyeZıpladı", true);
                Debug.Log("SENİN TAAAA AMINA KOYAYIM");

               

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
        _oyunBasiHareket = true;
        


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
