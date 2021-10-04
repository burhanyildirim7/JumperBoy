using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopingController : MonoBehaviour
{

    private int _seciliKarakterNumber;

    private int _shopingIlkGirisKontrol = 0;

    [SerializeField] private GameObject _birinciKarakter;

    [SerializeField] private GameObject _ikinciKarakter;

    [SerializeField] private GameObject _ucuncuKarakter;

 
    void Start()
    {
        _shopingIlkGirisKontrol = PlayerPrefs.GetInt("ShopingIlkGirisKontrol");
        _seciliKarakterNumber = PlayerPrefs.GetInt("SeciliKarakterNumber");

        if (_shopingIlkGirisKontrol == 0)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
        }
        else if (_seciliKarakterNumber == 1)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
        }
        else if (_seciliKarakterNumber == 2)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(true);
            _ucuncuKarakter.SetActive(false);
        }
        else if (_seciliKarakterNumber == 3)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(true);
        }
        else
        {

        }
    }

    
    void Update()
    {

        _seciliKarakterNumber = PlayerPrefs.GetInt("SeciliKarakterNumber");


        if (_seciliKarakterNumber == 1)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
        }
        else if (_seciliKarakterNumber == 2)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(true);
            _ucuncuKarakter.SetActive(false);
        }
        else if (_seciliKarakterNumber == 3)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(true);
        }
        else
        {

        }
    }

    public void BirinciKarakterButonu()
    {
        _seciliKarakterNumber = 1;
        PlayerPrefs.SetInt("SeciliKarakterNumber", _seciliKarakterNumber);
        _shopingIlkGirisKontrol = 1;
        PlayerPrefs.SetInt("ShopingIlkGirisKontrol", _shopingIlkGirisKontrol);
    }

    public void IkinciKarakterButonu()
    {
        _seciliKarakterNumber = 2;
        PlayerPrefs.SetInt("SeciliKarakterNumber", _seciliKarakterNumber);
        _shopingIlkGirisKontrol = 1;
        PlayerPrefs.SetInt("ShopingIlkGirisKontrol", _shopingIlkGirisKontrol);
    }

    public void UcuncuKarakterButonu()
    {
        _seciliKarakterNumber = 3;
        PlayerPrefs.SetInt("SeciliKarakterNumber", _seciliKarakterNumber);
        _shopingIlkGirisKontrol = 1;
        PlayerPrefs.SetInt("ShopingIlkGirisKontrol", _shopingIlkGirisKontrol);
    }
}
