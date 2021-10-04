using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{

    [SerializeField] private Transform _playerTransform;

    //private float _playerYukseklik;

    [SerializeField]
    GameObject myPlayer;
    [SerializeField]
    Rigidbody myPlayerRB;
    [SerializeField]
    Animator PlayerAnimator;


    void Update()
    {
        /*
        _playerYukseklik = (int)_playerTransform.position.y;

        if (_playerYukseklik >= 50)
        {
            UcusBaslangici();
        }
        else if (_playerYukseklik >= 5 && _playerYukseklik < 50)
        {
            DususBaslangici();
        }
        else
        {

        }
        */


        if (myPlayerRB.velocity.y < 0 && myPlayer.transform.position.y <= 1.5)
        {
            PlayerAnimator.SetBool("yereYaklasti", true);

        }
        if (myPlayerRB.velocity.y > 0 && myPlayer.transform.position.y > 1.5)
        {
            PlayerAnimator.SetBool("yereYaklasti", false);
            PlayerAnimator.SetBool("İkinciyeZıpladı", false);
        }


    }
    /*
    private void UcusBaslangici()
    {
        //Debug.Log("Ucus Basladi");
    }

    private void DususBaslangici()
    {
        //Debug.Log("Dusus Basladi");
    }

    */
}
