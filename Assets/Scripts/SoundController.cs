using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{

    [SerializeField] private AudioSource _sesKaynagi;

    [SerializeField] private AudioClip _uiButtonsSound;

    [SerializeField] private AudioClip _upgradeButtonsSound;

    [SerializeField] private AudioClip _oyunSonuButtonsSound;

    [SerializeField] private AudioClip _elmasToplamaSound;


    public void UIButtonsSound()
    {
        _sesKaynagi.PlayOneShot(_uiButtonsSound);
    }

    public void UpgradeButtonsSound()
    {
        _sesKaynagi.PlayOneShot(_upgradeButtonsSound);
    }

    public void OyunSonuButtonsSound()
    {
        _sesKaynagi.PlayOneShot(_oyunSonuButtonsSound);
    }


}
