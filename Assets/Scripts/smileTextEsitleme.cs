using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smileTextEsitleme : MonoBehaviour
{

    [SerializeField]
    Text UstText;
    [SerializeField]
    Text AltText;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        AltText.text = UstText.text;
    }
}
