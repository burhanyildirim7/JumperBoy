using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinirCizgisi : MonoBehaviour
{
    [SerializeField] private MapController _mapController;


   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _mapController.YolEkle();
        }
    }
    
}
