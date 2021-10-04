using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject Camera2;
    [SerializeField]
    GameObject Camera1;

    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject TapTapObj;

    float araMesafe;
    float cameraFirstPositionY;
    bool cameraHazir;
    public static bool TapToStart;
    private float MyTimer;

    // Start is called before the first frame update
    void Start()
    {
        Camera2.SetActive(false);
        TapToStart = false;
        cameraHazir = false;
        cameraFirstPositionY = Camera2.transform.position.y; 
        TapTapObj.SetActive(false);
        
        //araMesafe = Camera2.transform.position.z - Player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
       // z eksenindeki hareketi
       if (cameraHazir==true)
        {
            Camera2.transform.position = new Vector3(Camera2.transform.position.x, Player.transform.position.y+8, Player.transform.position.z - 10);
        }
        else
        {
            if (TapToStart==true) 
            {
                MyTimer += Time.deltaTime;
                if (MyTimer>=2.3f)
                {
                   
                    kameraDegis();
                }


            }

            else
            {

            }
        }
        
    }
    void kameraDegis()
    {
        Camera2.SetActive(true);
        Camera1.SetActive(false);       
        Camera2.transform.position = new Vector3(0, 8, 8);
        Camera2.transform.eulerAngles = new Vector3(20, 360, 0);
        cameraHazir = true;
        TapTapObj.SetActive(true);
    }
  

}
