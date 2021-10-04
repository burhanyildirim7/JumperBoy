using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
     

 [SerializeField] private List<GameObject> _roadMembers;

    private float _positionZ = 1.0f;

    private int _yolSirasiSayac;




    void Start()
    {
        _positionZ = 5332f;
        _yolSirasiSayac = 0;


    }

    
    public void YolEkle()
    {
        if (_yolSirasiSayac == 0)
        {
            Instantiate(_roadMembers[0], new Vector3(0, 3.6f, _positionZ), transform.rotation);
            _positionZ += 1318f;
            _yolSirasiSayac += 1;
        }
        else if (_yolSirasiSayac == 1)
        {
            Instantiate(_roadMembers[1], new Vector3(0, 3.6f, _positionZ), transform.rotation);
            _positionZ += 1318f;
            _yolSirasiSayac += 1;
        }
        else if (_yolSirasiSayac == 2)
        {
            Instantiate(_roadMembers[2], new Vector3(0, 3.6f, _positionZ), transform.rotation);
            _positionZ += 1318f;
            _yolSirasiSayac += 1;
        }
        else if (_yolSirasiSayac == 3)
        {
            Instantiate(_roadMembers[3], new Vector3(0, 3.6f, _positionZ), transform.rotation);
            _positionZ += 1318f;

            _yolSirasiSayac = 0;
        }

    }
}
