using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody _playerRigidbody;

    [HideInInspector] public Vector3 pos { get { return transform.position; } }

    private bool _ikinciFirlatmaKontrol;

    private Vector3 _ikinciZiplamaForce;

    public LevelController _levelController;


    [SerializeField]
    ParticleSystem LapsSmoke;

    [SerializeField]
    GameObject LapsSmokeObj;


    [SerializeField]
    Animator PlayerAnimator;

    [SerializeField]
    GameObject polis1;

    [SerializeField]
    GameObject polis2;

    private int _ziplamaSayac = 0;

    int oyunBasiHareketSayaci=0;
    float denemesayac = 0;

    [SerializeField] private CameraShake _cameraShake;

    void Start()
    {
        _ikinciFirlatmaKontrol = false;

        _ziplamaSayac = 0;
        LapsSmokeObj.SetActive(false);
    }


    void Update()
    {
        if (_playerRigidbody.velocity.y<0 && transform.position.y<1)
        {
            LapsSmokeObj.SetActive(true);
        }
        else
        {

        }
    
    }

    public void PlayerFirlatma(Vector3 _playerForce)
    {
        //_playerForce = new Vector3(0f, _yukariFirlatmaKuvveti, _ileriFirlatmaKuvveti);
        _playerRigidbody.AddForce(_playerForce, ForceMode.Impulse);
        //_playerRigidbody.AddForce(transform.up * _yukariFirlatmaKuvveti * _sliderSonDeger);
        // _playerRigidbody.AddForce(transform.forward * _ileriFirlatmaKuvveti * _sliderSonDeger);


    }

    public void PlayerFirlatmaIki(Vector3 _playerForce)
    {
        //_playerForce = new Vector3(0f, _yukariFirlatmaKuvveti, _ileriFirlatmaKuvveti);
        _ikinciFirlatmaKontrol = true;
        _ikinciZiplamaForce = _playerForce;

        //_playerRigidbody.AddForce(_playerForce, ForceMode.Impulse);
        //_playerRigidbody.AddForce(transform.up * _yukariFirlatmaKuvveti * _sliderSonDeger);
        // _playerRigidbody.AddForce(transform.forward * _ileriFirlatmaKuvveti * _sliderSonDeger);


    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Zemin")
        {
            
            if (_ikinciFirlatmaKontrol == true && _ziplamaSayac <= 1)
            {
                //transform.position = new Vector3(transform.position.x, 1, transform.position.z);
                //transform.rotation = Quaternion.Euler(0, 0, 0);
                //_playerRigidbody.velocity = Vector3.zero;
                _playerRigidbody.AddForce(_ikinciZiplamaForce, ForceMode.Impulse);


                LapsSmoke.Emit(3);
                _ikinciFirlatmaKontrol = false;

                _ziplamaSayac += 1;
                Debug.Log("TAKILMADI ORRRRRRRROSPU COCUGU");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    _cameraShake.ShakeOnce();
                }
               
                _playerRigidbody.velocity = new Vector3(0, 0, 0);
                _levelController.EndGame();
                _levelController.KazancBelirle();
                _levelController.OdulObjectResim();
                LapsSmoke.Emit(20);
                Debug.Log("TAKILDI ORRRRRRRROSPU COCUGU");
            }
        }
        else
        {
            if (collision.gameObject.tag == "Zemin")
            {

                Debug.Log("HATANI SIKEM SENIN AMINA KODUGUM");

            }


        }


    }
    public void OyunBasiHareket()
    {
        if (transform.position.z < 18)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        else
        {
            polis1.SetActive(false);
            polis2.SetActive(false);
        }

    }





}
