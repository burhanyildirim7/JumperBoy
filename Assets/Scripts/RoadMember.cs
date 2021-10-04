using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMember : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private float _aradakiMesafeZ = 0f;

    private float _aradakiMesafeX = 0f;



   
    void Update()
    {
        _aradakiMesafeZ = _playerTransform.position.z - transform.position.z;

        _aradakiMesafeX = _playerTransform.position.x - transform.position.x;

        if (_aradakiMesafeZ >= 1000f && _aradakiMesafeX == 0)
        {
            Destroy(gameObject);
            
        }
        else
        {

        }

     
    }


}
