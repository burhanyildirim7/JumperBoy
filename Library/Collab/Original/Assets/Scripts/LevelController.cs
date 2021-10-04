using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class LevelController : MonoBehaviour
{

    [SerializeField] private Transform _playerTransform;

    [SerializeField] private Text _roadValueText;

    private float _roadValue;

    [SerializeField] private Slider _levelSlider;

    [SerializeField] private Slider _rekorMesafeSlider;

    private int _sliderSonDeger;

    [SerializeField] private Text _sliderSonDegerText;

    private float _rekorMesafe;

    [SerializeField] private Text _rekorMesafeText;

    private float _sliderLevelDeger;

    [SerializeField] private GameObject _winScreen;

    [SerializeField] private Rigidbody _playerRigidbody;

    private float _endGameTimer;

    private int _skorKatsayisi;

    private float _coins;

    private float _kazanilanCoins;

    [SerializeField] private Text _kazanilanCoinsText;

    [SerializeField] private GameObject _odulObjectResim;

    private Vector3 _odulObjectResimScale;

    private float _odulObjectResimScaleHesaplama;

    [SerializeField] private Text _odulResimDegerText;

    private int _odulResimDeger;
    //------------------------
    [SerializeField]
    List<GameObject> SadImoji = new List<GameObject>();
    [SerializeField]
    List<GameObject> StandartImoji = new List<GameObject>();
    [SerializeField]
    GameObject Yuzde10Imoji;
    [SerializeField]
    GameObject Yuzde0_10Imoji;
    [SerializeField]
    GameObject MaxBarAsimiImoji;
    List<string> SadText = new List<string>();
    List<string> StandartText = new List<string>();
    string maxBarAsimText;
    string yuzde10Text;
    string yuzde0_10Text;
    int text_sayac = 0;
    System.Random randomDeger = new System.Random();
    [SerializeField]
    Text ImojiText;
    [SerializeField]
    GameObject ImojiGrup;

    int imojiSayac=0;

    float EskiRekordDeger=0;
    //------------------------------
    [SerializeField]
    Animator Polis1Anim;
    [SerializeField]
    Animator Polis2Anim;

    [SerializeField]
    Animator PlayerAnim;

    [SerializeField]
    GameObject Polis1;
    [SerializeField]
    GameObject Polis2;

    //-------------------------------

    private bool _oyunSonuPolisYaratmaKontrol;

    private float OyunSonuPolisHareketTimer;

    [SerializeField] private GameObject _oyunSonuPolis1;

    [SerializeField] private GameObject _oyunSonuPolis2;

    [SerializeField] private Transform _oyunSonuPolis1Transform;

    [SerializeField] private Transform _oyunSonuPolis2Transform;

    private bool _oyunSonu;

    [SerializeField] private Animator _oyunSonuPolis1Animasyon;

    [SerializeField] private Animator _oyunSonuPolis2Animasyon;

    public GameObject ParlamaSpark2;
    public GameObject PatlamaEfektObj;

    void Start()
    {
        PatlamaEfektObj.SetActive(false);


        PlayerAnim.SetBool("100m", false);
        PlayerAnim.SetBool("SliderSonDeger", false);

        _oyunSonuPolis1.SetActive(false);
        _oyunSonuPolis2.SetActive(false);


        //------------
        EskiRekordDeger = PlayerPrefs.GetFloat("RekorMesafe");
        SadText.Add("Sorry..");
        SadText.Add("Opps..");
        SadText.Add("Try Again");

        StandartText.Add("Good");
        StandartText.Add("Good Job");
        StandartText.Add("Well Done");

        maxBarAsimText = "Excellent";
        yuzde10Text = "Awesome";
        yuzde0_10Text = "Perfect";

        SadImoji[0].SetActive(false);
        SadImoji[1].SetActive(false);
        StandartImoji[0].SetActive(false);
        StandartImoji[1].SetActive(false);
        StandartImoji[2].SetActive(false);

        Yuzde0_10Imoji.SetActive(false);
        Yuzde10Imoji.SetActive(false);
        MaxBarAsimiImoji.SetActive(false);

        ImojiGrup.SetActive(false);

        //---------


        _sliderSonDeger = 1000;
        _sliderSonDeger = PlayerPrefs.GetInt("SliderSonDeger");
        _sliderLevelDeger = _sliderSonDeger;
        _sliderSonDegerText.text = _sliderSonDeger.ToString();
        _rekorMesafe = PlayerPrefs.GetFloat("RekorMesafe");
        _endGameTimer = 0f;
        _coins = (int)PlayerPrefs.GetFloat("Coins");
        _kazanilanCoins = PlayerPrefs.GetFloat("KazanilanCoins");
        RekorMesafeSlider();
        _winScreen.SetActive(false);

        _oyunSonuPolisYaratmaKontrol = false;
        OyunSonuPolisHareketTimer = 0f;

        _oyunSonu = false;






    }


    void Update()
    {

        _roadValue = (int)_playerTransform.position.z;

        _coins = (int)PlayerPrefs.GetFloat("Coins");


        //------Animasyon 
        //OyunSonuPolisHareket();
       

        if (_roadValue < 100)
        {

           
            OyunSonuPolisHareketTimer += Time.deltaTime;

            if (OyunSonuPolisHareketTimer >= 1)
            {
               

            }

            PlayerAnim.SetBool("100m", true);




        }
        else if (_roadValue > 100 && _roadValue < EskiRekordDeger)
        {
            PlayerAnim.SetBool("100m", false);
        }
        else if (_roadValue > EskiRekordDeger && _roadValue < _sliderSonDeger)
        {
            PlayerAnim.SetBool("100m", false);
            PlayerAnim.SetBool("SliderSonDeger", false);
        }
        else if (_roadValue >= _sliderSonDeger)
        {
            PlayerAnim.SetBool("SliderSonDeger", true);
        }
        else
        {

        }
        //----------------


       

        EndGame();

        if (_roadValue >= 0)
        {
            _roadValueText.text = _roadValue + " m";
            _levelSlider.value = (_roadValue / _sliderSonDeger);

        }
        else
        {

        }

        if (_roadValue > _rekorMesafe)
        {
            RekorMesafe();
        }
        else
        {

        }

        if (_oyunSonu == true && _roadValue < 250)
        {
            OyunSonuPolisYaratma();
        }
       

    }

    private void SliderDegerBelirleme()
    {

        _skorKatsayisi = (int)(_rekorMesafe / 1000);
        _sliderLevelDeger = (_skorKatsayisi + 1) * 1000;
        PlayerPrefs.SetInt("SliderSonDeger", (int)_sliderLevelDeger);


    }

    private void RekorMesafe()
    {
        _rekorMesafe = _roadValue;
        PlayerPrefs.SetFloat("RekorMesafe", _rekorMesafe);
    }

    private void RekorMesafeSlider()
    {
        _rekorMesafeText.text = _rekorMesafe + " m";
        _rekorMesafeSlider.value = (_rekorMesafe / _sliderSonDeger);
    }

    public void SceneChangedButton()
    {

        _kazanilanCoins = PlayerPrefs.GetFloat("KazanilanCoins");
        _coins = (int)PlayerPrefs.GetFloat("Coins");
        _coins = _coins + _kazanilanCoins;
        PlayerPrefs.SetFloat("Coins", _coins);
        SliderDegerBelirleme();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void KazancBelirle()
    {
        _kazanilanCoins = _roadValue;
        PlayerPrefs.SetFloat("KazanilanCoins", _kazanilanCoins);
    }

    public void UcKatKazanButonu()
    {
        _kazanilanCoins = PlayerPrefs.GetFloat("KazanilanCoins");
        _coins = (int)PlayerPrefs.GetFloat("Coins");
        _coins = _coins + (_kazanilanCoins * 3);
        PlayerPrefs.SetFloat("Coins", _coins);
        SliderDegerBelirleme();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void EndGame()
    {
        if (_playerRigidbody.velocity.z <= 0 && _roadValue > 20)
        {
            _endGameTimer += Time.deltaTime;
            //  Polis1.SetActive(true);
            //  Polis2.SetActive(true);
            //  Polis1.transform.position = _playerTransform.transform.position - new Vector3(2,0,10);
            //  Polis2.transform.position = _playerTransform.transform.position - new Vector3(-2, 0, 10);
            _oyunSonuPolis1.SetActive(true);
            _oyunSonuPolis2.SetActive(true);

            _oyunSonu = true;
            if (FlyingController.sliderDegerTemp==true)
            {
                ParlamaSpark2.SetActive(false);
                PatlamaEfektObj.SetActive(true);
                
            }
            else
            {
                PatlamaEfektObj.SetActive(false);
            }




            if (_endGameTimer >= 3)
            {
                _winScreen.SetActive(true);
                _kazanilanCoins = PlayerPrefs.GetFloat("KazanilanCoins");
                _kazanilanCoinsText.text = "$" + _kazanilanCoins;
                EmojiGrupControl();
            }


        }

    }

    private void OyunSonuPolisYaratma()
    {
        if (_oyunSonuPolisYaratmaKontrol == false)
        {
            _oyunSonuPolis1Transform.position = new Vector3(3f, 0.2f, _playerTransform.position.z - 48f);
            _oyunSonuPolis2Transform.position = new Vector3(-3f, 0.2f, _playerTransform.position.z - 48f);

            _oyunSonuPolisYaratmaKontrol = true;

            _oyunSonuPolis1Animasyon.SetBool("Run", true);
            _oyunSonuPolis2Animasyon.SetBool("Run", true);
        }
       
    }

    private void OyunSonuPolisHareket()
    {

        if (Polis1.transform.position.z < _roadValue)
        {
            Polis1.transform.Translate(Vector3.forward * Time.deltaTime * 10);
            Polis2.transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        else
        {

        }
    }

    public void GeciciDegerSifirlamaButon()
    {
        _rekorMesafe = 100;
        PlayerPrefs.SetFloat("RekorMesafe", _rekorMesafe);
        _sliderSonDeger = 1000;
        PlayerPrefs.SetInt("SliderSonDeger", _sliderSonDeger);
    }

    public void OdulObjectResim()
    {
        _rekorMesafe = PlayerPrefs.GetFloat("RekorMesafe");

        if (_rekorMesafe <= 10000)
        {
            _odulObjectResimScaleHesaplama = 1.0f;
            _rekorMesafe = PlayerPrefs.GetFloat("RekorMesafe");
            _odulObjectResimScaleHesaplama -= (_rekorMesafe / 10000);
            _odulObjectResimScale = new Vector3(1.0f, _odulObjectResimScaleHesaplama, 1.0f);
            _odulObjectResim.transform.localScale = _odulObjectResimScale;
            _odulResimDeger = (int)(_rekorMesafe / 100);
            _odulResimDegerText.text = "%" + _odulResimDeger;
        }
        else
        {
            _odulObjectResimScale = new Vector3(1.0f, 0, 1.0f);
            _odulObjectResim.transform.localScale = _odulObjectResimScale;
            _odulResimDeger = (int)(100);
            _odulResimDegerText.text = "%" + _odulResimDeger;
        }



    }
    private void EmojiGrupControl() 
    {
        ImojiGrup.SetActive(true);
        
        imojiSayac++;
        if (imojiSayac==1)
        {
            if (_roadValue <= 100)
            {
                int sayi = randomDeger.Next(2);
                ImojiText.text = SadText[sayi];
                int sayi1 = randomDeger.Next(1);
                SadImoji[sayi1].SetActive(true);

            }
            else if (_roadValue > 100)
            {
                if (_roadValue <= (EskiRekordDeger))
                {
                    int sayi = randomDeger.Next(2);
                    ImojiText.text = StandartText[sayi];
                    int sayi1 = randomDeger.Next(2);
                    StandartImoji[sayi1].SetActive(true);
                }
                else if (_roadValue < (EskiRekordDeger * 1.1f) && _roadValue >= (EskiRekordDeger))
                {
                    ImojiText.text = yuzde0_10Text;
                    Yuzde0_10Imoji.SetActive(true);
                }
                else if (_roadValue > (EskiRekordDeger * 1.1f) && _roadValue < (_sliderSonDeger))
                {
                    ImojiText.text = yuzde10Text;
                    Yuzde10Imoji.SetActive(true);
                }
                else if (_roadValue >= (_sliderSonDeger))
                {
                    ImojiText.text = maxBarAsimText;
                    MaxBarAsimiImoji.SetActive(true);
                }
                else
                {

                }
            }

        }
        else
        {

        }

    }
}
//_sliderSonDeger
//_roadValue