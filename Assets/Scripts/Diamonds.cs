using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamonds : MonoBehaviour
{
    [SerializeField] private CoinsController CoinsController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CoinsController.GainDiamonds(1);
            Destroy(gameObject);
        }
    }
}
