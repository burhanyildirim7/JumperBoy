using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterSatinAlma : MonoBehaviour
{
    [SerializeField] private GameObject _birinciKarakter;

    [SerializeField] private GameObject _ikinciKarakter;

    [SerializeField] private GameObject _ucuncuKarakter;

    [SerializeField] private GameObject _dorduncuKarakter;

    [SerializeField] private GameObject _besinciKarakter;

    [SerializeField] private GameObject _altinciKarakter;

    private int _karakterSatinAlmaKontrol = 0;
    
    void Start()
    {
        _karakterSatinAlmaKontrol = PlayerPrefs.GetInt("KarakterSatinAlmaKontrol");

        if (_karakterSatinAlmaKontrol == 0)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 1)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 2)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(true);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 3)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(true);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 4)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(true);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 5)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(true);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 6)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(true);
        }
        else
        {

        }



    }


    void Update()
    {
        _karakterSatinAlmaKontrol = PlayerPrefs.GetInt("KarakterSatinAlmaKontrol");

        if (_karakterSatinAlmaKontrol == 0)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 1)
        {
            _birinciKarakter.SetActive(true);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 2)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(true);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 3)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(true);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 4)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(true);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 5)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(true);
            _altinciKarakter.SetActive(false);
        }
        else if (_karakterSatinAlmaKontrol == 6)
        {
            _birinciKarakter.SetActive(false);
            _ikinciKarakter.SetActive(false);
            _ucuncuKarakter.SetActive(false);
            _dorduncuKarakter.SetActive(false);
            _besinciKarakter.SetActive(false);
            _altinciKarakter.SetActive(true);
        }
        else
        {

        }
    }

    public void BirinciKarakterSecmeButonu()
    {  
        _karakterSatinAlmaKontrol = 1;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);

    }

    public void IkinciKarakterSecmeButonu()
    { 
        _karakterSatinAlmaKontrol = 2;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);
    }

    public void UcuncuKarakterSecmeButonu()
    {
        _karakterSatinAlmaKontrol = 3;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);
    }

    public void DorduncuKarakterSecmeButonu()
    {  
        _karakterSatinAlmaKontrol = 4;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);
    }

    public void BesinciKarakterSecmeButonu()
    {   
        _karakterSatinAlmaKontrol = 5;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);
    }

    public void AltinciKarakterSecmeButonu()
    {  
        _karakterSatinAlmaKontrol = 6;
        PlayerPrefs.SetInt("KarakterSatinAlmaKontrol", _karakterSatinAlmaKontrol);
    }
}
