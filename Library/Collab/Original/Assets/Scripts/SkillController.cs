using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    private int _ilkGirisKontrol = 0;

    // STRENGTH SKILL

    private int _strengthSkillLevel = 1;
    private int _strengthLevelPrice = 200;
    [SerializeField] private Text _strengthLevelText;
    [SerializeField] private Text _strengthLevelPriceText;
    private float _yukariForce = 5f;
    [SerializeField] private Button _strengthSkillButton;

    // SPEED SKILL

    private int _speedSkillLevel = 1;
    private int _speedLevelPrice = 200;
    private float _ileriForce = 5f;
    [SerializeField] private Text _speedLevelText;
    [SerializeField] private Text _speedLevelPriceText;
    [SerializeField] private Button _speedSkillButton;

    // BOUNCINESS SKILL

    private int _bouncinessSkillLevel = 1;
    private int _bouncinessLevelPrice = 200;
    [SerializeField] private Text _bouncinessLevelText;
    [SerializeField] private Text _bouncinessLevelPriceText;
    private float _ikinciIleriForce = 2f;
    private float _ikinciYukariForce = 2f;
    [SerializeField] private Button _bouncinessSkillButton;

    // OFFLINE EARNING SKILL

    private int _offlineEarningSkillLevel = 1;
    private int _offlineEarningLevelPrice = 200;
    [SerializeField] private Text _offlineEarningLevelText;
    [SerializeField] private Text _offlineEarningLevelPriceText;
    private int _amountPerHour = 60;
    private int _amountPerMinute = 1;
    [SerializeField] private Button _offlineEarningSkillButton;

    // DIGER

    private float _coins;

    void Start()
    {
        
        _ilkGirisKontrol = PlayerPrefs.GetInt("IlkGirisKontrol");
        _coins = PlayerPrefs.GetFloat("Coins");

        if (_ilkGirisKontrol == 0)
        {
            // STRENGTH SKILL

            _strengthSkillLevel = 1;
            _strengthLevelPrice = 200;
            _yukariForce = 5f;
            PlayerPrefs.SetInt("StrengthSkillLevel", _strengthSkillLevel);
            PlayerPrefs.SetInt("StrengthLevelPrice", _strengthLevelPrice);
            PlayerPrefs.SetFloat("YukariForce", _yukariForce);

            // SPEED SKILL

            _speedSkillLevel = 1;
            _speedLevelPrice = 200;
            _ileriForce = 5f;
            PlayerPrefs.SetInt("SpeedSkillLevel", _speedSkillLevel);
            PlayerPrefs.SetInt("SpeedLevelPrice", _speedLevelPrice);
            PlayerPrefs.SetFloat("IleriForce", _ileriForce);

            // BOUNCINESS SKILL

            _bouncinessSkillLevel = 1;
            _bouncinessLevelPrice = 200;
            _ikinciIleriForce = 2f;
            _ikinciYukariForce = 2f;
            PlayerPrefs.SetInt("BouncinessSkillLevel", _bouncinessSkillLevel);
            PlayerPrefs.SetInt("BouncinessLevelPrice", _bouncinessLevelPrice);
            PlayerPrefs.SetFloat("IkinciIleriForce", _ikinciIleriForce);
            PlayerPrefs.SetFloat("IkinciYukariForce", _ikinciYukariForce);

            // OFFLINE EARNING SKILL

            _offlineEarningSkillLevel = 1;
            _offlineEarningLevelPrice = 200;
            _amountPerHour = 60;
            _amountPerMinute = 1;
            PlayerPrefs.SetInt("OfflineEarningSkillLevel", _offlineEarningSkillLevel);
            PlayerPrefs.SetInt("OfflineEarningLevelPrice", _offlineEarningLevelPrice);
            PlayerPrefs.SetInt("AmountPerHour", _amountPerHour);
            PlayerPrefs.SetInt("AmountPerMinute", _amountPerMinute);

            _ilkGirisKontrol = 1;
            PlayerPrefs.SetInt("IlkGirisKontrol", _ilkGirisKontrol);
        }
        else
        {

        }
        // STRENGTH SKILL

        _strengthSkillLevel = PlayerPrefs.GetInt("StrengthSkillLevel");
        _strengthLevelPrice = PlayerPrefs.GetInt("StrengthLevelPrice");
        _yukariForce = PlayerPrefs.GetFloat("YukariForce");

        // SPEED SKILL

        _speedSkillLevel = PlayerPrefs.GetInt("SpeedSkillLevel");
        _speedLevelPrice = PlayerPrefs.GetInt("SpeedLevelPrice");
        _ileriForce = PlayerPrefs.GetFloat("IleriForce");

        // BOUNCINESS SKILL

        _bouncinessSkillLevel = PlayerPrefs.GetInt("BouncinessSkillLevel");
        _bouncinessLevelPrice = PlayerPrefs.GetInt("BouncinessLevelPrice");
        _ikinciIleriForce = PlayerPrefs.GetFloat("IkinciIleriForce");
        _ikinciYukariForce = PlayerPrefs.GetFloat("IkinciYukariForce");

        // OFFLINE EARNING SKILL

        _offlineEarningSkillLevel = PlayerPrefs.GetInt("OfflineEarningSkillLevel");
        _offlineEarningLevelPrice = PlayerPrefs.GetInt("OfflineEarningLevelPrice");
        _amountPerHour = PlayerPrefs.GetInt("AmountPerHour");
        _amountPerMinute = PlayerPrefs.GetInt("AmountPerMinute");

        // DIGER



    }


    void Update()
    {

        _coins = PlayerPrefs.GetFloat("Coins");

        // STRENGTH SKILL

        _strengthSkillLevel = PlayerPrefs.GetInt("StrengthSkillLevel");
        _strengthLevelPrice = PlayerPrefs.GetInt("StrengthLevelPrice");
        _yukariForce = PlayerPrefs.GetFloat("YukariForce");
        _strengthLevelText.text = "(" + _strengthSkillLevel + ")";
        _strengthLevelPriceText.text = "$" + _strengthLevelPrice;

        // SPEED SKILL

        _speedSkillLevel = PlayerPrefs.GetInt("SpeedSkillLevel");
        _speedLevelPrice = PlayerPrefs.GetInt("SpeedLevelPrice");
        _ileriForce = PlayerPrefs.GetFloat("IleriForce");
        _speedLevelText.text = "(" + _speedSkillLevel + ")";
        _speedLevelPriceText.text = "$" + _speedLevelPrice;

        // BOUNCINESS SKILL

        _bouncinessSkillLevel = PlayerPrefs.GetInt("BouncinessSkillLevel");
        _bouncinessLevelPrice = PlayerPrefs.GetInt("BouncinessLevelPrice");
        _ikinciIleriForce = PlayerPrefs.GetFloat("IkinciIleriForce");
        _ikinciYukariForce = PlayerPrefs.GetFloat("IkinciYukariForce");
        _bouncinessLevelText.text = "(" + _bouncinessSkillLevel + ")";
        _bouncinessLevelPriceText.text = "$" + _bouncinessLevelPrice;

        // OFFLINE EARNING SKILL

        _offlineEarningSkillLevel = PlayerPrefs.GetInt("OfflineEarningSkillLevel");
        _offlineEarningLevelPrice = PlayerPrefs.GetInt("OfflineEarningLevelPrice");
        _amountPerHour = PlayerPrefs.GetInt("AmountPerHour");
        _amountPerMinute = PlayerPrefs.GetInt("AmountPerMinute");
        _offlineEarningLevelText.text = "(" + _offlineEarningSkillLevel + ")";
        _offlineEarningLevelPriceText.text = "$" + _offlineEarningLevelPrice;

        // DIGER

        if (_coins < _strengthLevelPrice)
        {
            _strengthSkillButton.interactable = false;
        }
        else
        {
            _strengthSkillButton.interactable = true;
        }

        if (_coins < _speedLevelPrice)
        {
            _speedSkillButton.interactable = false;
        }
        else
        {
            _speedSkillButton.interactable = true;
        }

        if (_coins < _bouncinessLevelPrice)
        {
            _bouncinessSkillButton.interactable = false;
        }
        else
        {
            _bouncinessSkillButton.interactable = true;
        }

        if (_coins < _offlineEarningLevelPrice)
        {
            _offlineEarningSkillButton.interactable = false;
        }
        else
        {
            _offlineEarningSkillButton.interactable = true;
        }

    }

    public void StrenghtSkillUpgrade()
    {
        if (_coins >= _strengthLevelPrice)
        {
            _coins = _coins - _strengthLevelPrice;
            _strengthSkillLevel += 1;
            _strengthLevelPrice += 50;
            _yukariForce += 0.05f;
            PlayerPrefs.SetInt("StrengthSkillLevel", _strengthSkillLevel);
            PlayerPrefs.SetInt("StrengthLevelPrice", _strengthLevelPrice);
            PlayerPrefs.SetFloat("YukariForce", _yukariForce);
            PlayerPrefs.SetFloat("Coins", _coins);
        }
        else
        {

        }

    }

    public void SpeedSkillUpgrade()
    {
        if (_coins >= _speedLevelPrice)
        {
            _coins = _coins - _speedLevelPrice;
            _speedSkillLevel += 1;
            _speedLevelPrice += 50;
            _ileriForce += 1f;
            PlayerPrefs.SetInt("SpeedSkillLevel", _speedSkillLevel);
            PlayerPrefs.SetInt("SpeedLevelPrice", _speedLevelPrice);
            PlayerPrefs.SetFloat("IleriForce", _ileriForce);
            PlayerPrefs.SetFloat("Coins", _coins);
        }
        else
        {

        }

    }

    public void BouncinessSkillUpgrade()
    {
        if (_coins >= _bouncinessLevelPrice)
        {
            _coins = _coins - _bouncinessLevelPrice;
            _bouncinessSkillLevel += 1;
            _bouncinessLevelPrice += 50;
            _ikinciIleriForce += 1f;
            _ikinciYukariForce += 0.05f;
            PlayerPrefs.SetInt("BouncinessSkillLevel", _bouncinessSkillLevel);
            PlayerPrefs.SetInt("BouncinessLevelPrice", _bouncinessLevelPrice);
            PlayerPrefs.SetFloat("IkinciIleriForce", _ikinciIleriForce);
            PlayerPrefs.SetFloat("IkinciYukariForce", _ikinciYukariForce);
            PlayerPrefs.SetFloat("Coins", _coins);
        }
        else
        {

        }

    }

    public void OfflineEarningSkillUpgrade()
    {
        if (_coins >= _offlineEarningLevelPrice)
        {
            _coins = _coins - _offlineEarningLevelPrice;
            _offlineEarningSkillLevel += 1;
            _offlineEarningLevelPrice += 50;
            _amountPerHour += 6;
            _amountPerMinute += 1;
            PlayerPrefs.SetInt("OfflineEarningSkillLevel", _offlineEarningSkillLevel);
            PlayerPrefs.SetInt("OfflineEarningLevelPrice", _offlineEarningLevelPrice);
            PlayerPrefs.SetInt("AmountPerHour", _amountPerHour);
            PlayerPrefs.SetInt("AmountPerMinute", _amountPerMinute);
            PlayerPrefs.SetFloat("Coins", _coins);
        }
        else
        {

        }

    }
}
