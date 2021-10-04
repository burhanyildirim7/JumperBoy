using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class UI_2_Controller : MonoBehaviour
{
    [SerializeField]
    GameObject SkinPanel;
    [SerializeField]
    GameObject UpgradePanel;
    [SerializeField]
    GameObject SettingsPanel;

    [SerializeField]
    GameObject SkinButton;
    [SerializeField]
    GameObject UpgradeButton;
    [SerializeField]
    GameObject SettingsButton;

    [SerializeField]
    GameObject CloseMenuButton;

    [SerializeField]
    GameObject OpenMenuCanvas;

    [SerializeField]
    GameObject VolOnButton;
    [SerializeField]
    GameObject VolOffButton;

    [SerializeField]
    Animator CloseMenuAnimator;

    [SerializeField] private SoundController _soundController;

    // Start is called before the first frame update
    void Start()
    {
        OpenMenuCanvas.SetActive(false);
        CloseMenuAnimator.SetBool("Close", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Open Menu Control

    public void CloseMenuButtonFunc() 
    {
        CloseMenuAnimator.SetBool("Close",true);
        Invoke("CloseMenuFunc",0.5f);
    }

    public void SkinPanelButton() 
    {
        _soundController.UIButtonsSound();

        OpenMenuCanvas.SetActive(true);

        SkinPanel.SetActive(true);
        UpgradePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        CloseMenuButton.SetActive(true);
        CloseMenuButton.GetComponent<Image>().color = new Color32(150, 99, 255, 100);

    }
    public void UpgradePanelButton()
    {
        _soundController.UIButtonsSound();

        OpenMenuCanvas.SetActive(true);

        SkinPanel.SetActive(false);
        UpgradePanel.SetActive(true);
        SettingsPanel.SetActive(false);
        CloseMenuButton.SetActive(true);
        CloseMenuButton.GetComponent<Image>().color = new Color32(252, 215, 182, 100);


    }
    public void SettingsPanelButton()
    {
        _soundController.UIButtonsSound();

        OpenMenuCanvas.SetActive(true);

        SkinPanel.SetActive(false);
        UpgradePanel.SetActive(false);
        SettingsPanel.SetActive(true);
        CloseMenuButton.SetActive(true);
        CloseMenuButton.GetComponent<Image>().color = new Color32(45, 48, 52, 100);
    }

    public void CloseMenuFunc()
    {
       // _soundController.UIButtonsSound();

        SkinPanel.SetActive(false);
        UpgradePanel.SetActive(false);
        SettingsPanel.SetActive(false);

        CloseMenuButton.SetActive(false);

        OpenMenuCanvas.SetActive(false);

    }

    //
    // Ust Barın Kontrolü

    //
    //Settings Menusu

    public void VolOn() 
    {
        _soundController.UIButtonsSound();

        VolOffButton.SetActive(true);
        VolOnButton.SetActive(false);

    }
    public void VolOff()
    {
        _soundController.UIButtonsSound();

        VolOnButton.SetActive(true);
        VolOffButton.SetActive(false);

    }

}
