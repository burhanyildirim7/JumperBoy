using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CoinsController : MonoBehaviour
{
    [SerializeField] private Text _coinsText;

    private float _coins;

    [SerializeField] private int _amountPerHour;

    [SerializeField] private int _amountPerMinute;

    private DateTime _leaveDate;

    private DateTime _openDate;

    private float _timeOfflineMinute;

    private float _timeOfflineHour;

    private int _diamonds;

    [SerializeField] private Text _diamondsText;

    void Start()
    {
        _openDate = System.DateTime.Now;
        long temp = Convert.ToInt64(PlayerPrefs.GetString("oldDate"));
        _leaveDate = DateTime.FromBinary(temp);
        _timeOfflineHour = _openDate.Subtract(_leaveDate).Hours;
        _timeOfflineMinute = _openDate.Subtract(_leaveDate).Minutes;
        _amountPerHour = PlayerPrefs.GetInt("AmountPerHour");
        _amountPerMinute = PlayerPrefs.GetInt("AmountPerMinute");
        _diamonds = PlayerPrefs.GetInt("Diamonds");

        _coins = (int)PlayerPrefs.GetFloat("Coins");
        _coins = _coins + (_timeOfflineHour * _amountPerHour);
        _coins = _coins + (_timeOfflineMinute * _amountPerMinute);
        
        print("Coins =" + " OldCoins + (TimeOfflineHour: " + _timeOfflineHour + " * AmountPerHour: " + _amountPerHour + ") + (TimeOfflineMinute: " + _timeOfflineMinute + " * AmountPerMinute: " + _amountPerMinute + ") = " + _coins);
        print(_amountPerHour * _timeOfflineHour);
        print(_amountPerMinute * _timeOfflineMinute);
        print("Loaded Coins: " + _coins);
    }

    private void OnApplicationQuit()
    {
        
        PlayerPrefs.SetFloat("Coins", _coins);
        PlayerPrefs.SetInt("AmountPerHour", _amountPerHour);
        PlayerPrefs.SetInt("AmountPerMinute", _amountPerMinute);
        PlayerPrefs.SetString("oldDate", System.DateTime.Now.ToBinary().ToString());
        print("Saved Coins : " + _coins);
    }
    void Update()
    {
        _diamonds = PlayerPrefs.GetInt("Diamonds");
        _coins = (int)PlayerPrefs.GetFloat("Coins");
        _coinsText.text = "$" + _coins;
        _diamondsText.text = _diamonds.ToString();
    }

    public void GainDiamonds(int _diamondValue)
    {
        _diamonds += _diamondValue;
        PlayerPrefs.SetInt("Diamonds", _diamonds);
    }
}
