using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTextControl : MonoBehaviour
{
    [SerializeField]
    Text StrengthText1;
    [SerializeField]
    Text StrengthText2;
    [SerializeField]
    Text SpeedText1;
    [SerializeField]
    Text SpeedText2;
    [SerializeField]
    Text BouncinessText1;
    [SerializeField]
    Text BouncinessText2;
    [SerializeField]
    Text IdleEarnText1;
    [SerializeField]
    Text IdleEarnText2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       StrengthText2.text = StrengthText1.text;
       SpeedText2.text = SpeedText1.text;
       BouncinessText2.text = BouncinessText1.text;
       IdleEarnText2.text = IdleEarnText1.text;
    }
}
