using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class UI_Controller : MonoBehaviour
{
    //public Image color;
    private Vector3 openMenuPosition = new Vector3(0,-500,0);
    private Vector3 closeMenuPosition;
    
    [SerializeField]
    Animator AltMenuAnimator;


    [SerializeField]
    GameObject SkinCanvas;

    [SerializeField]
    GameObject UpgradeCanvas;
 
    [SerializeField]
    GameObject SettingsCanvas;

    [SerializeField]
    GameObject MenuKapatmaButtonu;

    [SerializeField]
    GameObject SesAcButtonu;

    [SerializeField]
    GameObject SesKapatButtonu;

    private bool animController;

    void Start()
    {
        SkinCanvas.SetActive(false);

        UpgradeCanvas.SetActive(false);

        SettingsCanvas.SetActive(false);

        MenuKapatmaButtonu.SetActive(false);
        animController = false;
    }


    void Update()
    {
        
    }

    public void SkinButton() 
    {
       

        SkinCanvas.SetActive(true);

        UpgradeCanvas.SetActive(false);

        SettingsCanvas.SetActive(false);

        MenuKapatmaButtonu.SetActive(true);
        MenuKapatmaButtonu.GetComponent<Image>().color = new Color32(51,153,204,100);

        MenuUp();
    }
    public void UpgradeButton()
    {
      
        SkinCanvas.SetActive(false);

        UpgradeCanvas.SetActive(true);

        SettingsCanvas.SetActive(false);

        MenuKapatmaButtonu.SetActive(true);
        MenuKapatmaButtonu.GetComponent<Image>().color = new Color32 (102,51,204,100);

        MenuUp();
      
    }
    public void SettingsButton()
    {
        

        SkinCanvas.SetActive(false);

        UpgradeCanvas.SetActive(false);

        SettingsCanvas.SetActive(true);

        MenuKapatmaButtonu.SetActive(true);
        MenuKapatmaButtonu.GetComponent<Image>().color = new Color32(100,100,100,100);

        MenuUp();
    }
    public void MenuKapatmaFonksiyonu()
    {
        MenuDown();
        Invoke("menuKapat",0.5f);
    }

    public void MenuUp() 
    {
        if (animController==false)
        {
            AltMenuAnimator.SetBool("Open", true);
            animController = true;
        }
     

    }
    public void MenuDown()
    {

        AltMenuAnimator.SetBool("Open",false);
        animController = false;
    }
    private void menuKapat() 
    {
        SkinCanvas.SetActive(false);

        UpgradeCanvas.SetActive(false);

        SettingsCanvas.SetActive(false);

        MenuKapatmaButtonu.SetActive(false);
    }

    public void SesAc() 
    {
        //ses acma kodu yazılacak

        SesKapatButtonu.SetActive(true);
        SesAcButtonu.SetActive(false);
    }
    public void SesKapat()
    {

        //ses kapatma kodu yazılacak

        SesAcButtonu.SetActive(true);
        SesKapatButtonu.SetActive(false);
    }



}
