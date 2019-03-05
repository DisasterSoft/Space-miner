using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject menuPanel, marketPanel, bootsPanel, purpleIn, redIn, blueIn, purpleRombusIn, blueHillIn, opalIn, purpleOUT, opalOUT,opalBootsNS,settingPanel,soundCraft;
    public static GameObject opalBoots;
    public static bool menuIsOpened=false;
    public Slider slider1, slider2, slider3, slider4, slider5, slider6,sliderVolume;
    public static bool marketIsOpened = false;
    public static bool bootsIsOpened = false;
    public static bool settingIsOpened = false;

    
    public void menuClicked()
    {
        if (!menuIsOpened)
        {
            menuPanel.SetActive(true);
            menuPanel.GetComponent<Animation>().Play("menuApper");
            menuIsOpened = true;
        }
        else
        {
            StartCoroutine(menuFade_routine());
        }
    }
    public void panelClicked()
    {
        if (menuIsOpened)
        {
            StartCoroutine(menuFade_routine());
 
        }
    }
    public void marketClicked()
    {
        if (!marketIsOpened)
        {
            marketPanel.SetActive(true);
            marketPanel.GetComponent<Animation>().Play("marketApper");
            marketIsOpened = true;
            purpleIn.GetComponent<Text>().text = globalCrystal.purpleHillC.ToString()+" ";
            redIn.GetComponent<Text>().text = globalCrystal.redC.ToString() + " ";
            blueIn.GetComponent<Text>().text = globalCrystal.blueC.ToString() + " ";
            purpleRombusIn.GetComponent<Text>().text = globalCrystal.purpelRombusC.ToString() + " ";
            blueHillIn.GetComponent<Text>().text = globalCrystal.blueHillC.ToString() + " ";
            opalIn.GetComponent<Text>().text = globalCrystal.greenOaplC.ToString() + " ";
            opalOUT.GetComponent<Text>().text = "0";
            purpleOUT.GetComponent<Text>().text = "0";
            slider1.maxValue = float.Parse(globalCrystal.purpleHillC);
            slider1.minValue = 0;
            slider1.wholeNumbers=true;
            slider2.maxValue = float.Parse(globalCrystal.redC);
            slider2.minValue = 0;
            slider3.maxValue = float.Parse(globalCrystal.blueC);
            slider3.minValue = 0;
            slider4.maxValue = float.Parse(globalCrystal.purpelRombusC);
            slider4.minValue = 0;
            slider5.maxValue = float.Parse(globalCrystal.blueHillC);
            slider5.minValue = 0;
            slider6.maxValue = float.Parse(globalCrystal.greenOaplC);
            slider6.minValue = 0;
        }
        else
        {
            StartCoroutine(marketFade_routine());
        }
    }
    public void marketClosed()
    {
        if (marketIsOpened)
        {
            StartCoroutine(marketFade_routine());
           
           
        }
    }
    public void bootsClicked()
    {
        if (!bootsIsOpened)
        {
            bootsPanel.SetActive(true);
            bootsPanel.GetComponent<Animation>().Play("bootsApper");
            bootsIsOpened = true;
            opalBootsNS.GetComponent<Text>().text =globalCrystal.greenOaplC;
           
            
        }
        else
        {
            StartCoroutine(bootsFade_routine());
        }
    }
    public void bootsClosed()
    {
        if (bootsIsOpened)
        {
            StartCoroutine(bootsFade_routine());
           
           
        }
    }
    public void settingClicked()
    {
        if (!settingIsOpened)
        {
            settingPanel.SetActive(true);
            settingPanel.GetComponent<Animation>().Play("settingApper");
            settingIsOpened = true;
           
           
            
        }
        else
        {
            StartCoroutine(settingFade_routine());
        }
    }
    public void settingClosed()
    {
        if (settingIsOpened)
        {
            StartCoroutine(settingFade_routine());
           
           
        }
    }
    IEnumerator menuFade_routine()
    {
        menuPanel.GetComponent<Animation>().Play("menuFade");
        yield return new WaitForSeconds(1.2f);
        menuIsOpened = false;
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator marketFade_routine()
    {
        marketPanel.GetComponent<Animation>().Play("marketFade");
        yield return new WaitForSeconds(1.2f);
        marketPanel.SetActive(false);
        marketIsOpened = false;
        slider1.value = 0;
        slider2.value = 0;
        slider3.value = 0;
        slider4.value = 0;
        slider5.value = 0;
        slider6.value = 0;
    }
    IEnumerator bootsFade_routine()
    {
        bootsPanel.GetComponent<Animation>().Play("bootsFade");
        yield return new WaitForSeconds(1.2f);
       bootsPanel.SetActive(false);
       bootsIsOpened = false;
       
    }
    IEnumerator settingFade_routine()
    {
        settingPanel.GetComponent<Animation>().Play("settingFade");
        yield return new WaitForSeconds(1.2f);
        settingPanel.SetActive(false);
        settingIsOpened = false;
       
    }
   
   
}
