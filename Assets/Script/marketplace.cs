using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marketplace : MonoBehaviour
{
    public GameObject purpleIn, redIn, blueIn, purpleRombusIn, blueHillIn, opalIn, purpleOUT, opalOUT, marketPanel;
    public Slider slider1, slider2, slider3, slider4, slider5, slider6;
    public Dropdown dropdown;
    public GameObject OkButton;
    public int dropdownValue;
    public int dummydropdownValue=0;
    public int sliderValue1,sliderValue2,sliderValue3,sliderValue4,sliderValue5,sliderValue6;
    public int dummyValue1 = 0;
    public int dummyValue2 = 0;
    public int dummyValue3 = 0;
    public int dummyValue4 = 0;
    public int dummyValue5 = 0;
    public int dummyValue6 =0;
    public float osszeg;
    
  

    // Update is called once per frame
    void Update()
    {
       
        //a lenyílló menű alapján mindent változtatunk.
        dropdownValue = dropdown.value;
        //ha megváltoztattuk a lenyíló menűt, minden vissza áll alapba
        if(dropdownValue!=dummydropdownValue)
        {
            slider1.value = 0;
            slider2.value = 0;
            slider3.value = 0;
            slider4.value = 0;
            slider5.value = 0;
            slider6.value = 0;
        }
        if(dropdownValue==0)
        {
            slider1.interactable = false;
            slider2.interactable = false;
            slider3.interactable = false;
            slider4.interactable = false;
            slider5.interactable = false;
            slider6.interactable = false;
           
            purpleOUT.GetComponent<Text>().text = "0";
            opalOUT.GetComponent<Text>().text = "0";
        }
        if (dropdownValue==1)
        {
            slider1.interactable = false;
            slider2.interactable = true;
            slider3.interactable = true;
            slider4.interactable = true;
            slider5.interactable = true;
            slider6.interactable = true;
           
            opalOUT.GetComponent<Text>().text = "0";
             osszeg = (int)((sliderValue2 * 1.5f) + (sliderValue3 * 1.8f) + (sliderValue4*2) + (sliderValue5*2.2f) + (sliderValue6*2.5f));
            purpleOUT.GetComponent<Text>().text = osszeg.ToString();
        }
        if (dropdownValue==2)
        {
            slider1.interactable = true;
            slider2.interactable = true;
            slider3.interactable = true;
            slider4.interactable = true;
            slider5.interactable = true;
            slider6.interactable = false;
            purpleOUT.GetComponent<Text>().text = "0";
            osszeg = (int)((sliderValue1*0.0100f) + (sliderValue2*0.070f) + (sliderValue3 *0.060f) + (sliderValue4 *0.050f) + (sliderValue5 *0.040f));
           opalOUT.GetComponent<Text>().text = osszeg.ToString();
        } 
        //ha az első csúszkát mozgatjuk
        sliderValue1 = (int)slider1.value;
        if(dummyValue1<sliderValue1)
        {
            purpleIn.GetComponent<Text>().text = (slider1.maxValue - sliderValue1).ToString();
           
        }
        if (dummyValue1 > sliderValue1)
        {
            purpleIn.GetComponent<Text>().text = (slider1.maxValue - sliderValue1).ToString();
          
        }
        dummyValue1 = sliderValue1;
        //ha az 2 csúszkát mozgatjuk
        sliderValue2 = (int)slider2.value;
        if (dummyValue2<sliderValue2)
        {
            redIn.GetComponent<Text>().text = (slider2.maxValue - sliderValue2).ToString();
           
        }
        if (dummyValue2 > sliderValue2)
        {
            redIn.GetComponent<Text>().text = (slider2.maxValue - sliderValue2).ToString();
            
        }
        dummyValue2 = sliderValue2;
        // ha az 3 csúszkát mozgatjuk
        sliderValue3 = (int)slider3.value;
        if(dummyValue3<sliderValue3)
        {
            blueIn.GetComponent<Text>().text = (slider3.maxValue - sliderValue3).ToString();
           
        }
        if (dummyValue3 > sliderValue3)
        {
            blueIn.GetComponent<Text>().text = (slider3.maxValue - sliderValue3).ToString();
           
        }
        dummyValue3 = sliderValue3;
        // ha az 4 csúszkát mozgatjuk
        sliderValue4 = (int)slider4.value;
        if(dummyValue4<sliderValue4)
        {
            purpleRombusIn.GetComponent<Text>().text = (slider4.maxValue - sliderValue4).ToString();
           
        }
        if (dummyValue4 > sliderValue4)
        {
            purpleRombusIn.GetComponent<Text>().text = (slider4.maxValue - sliderValue4).ToString();
           
        }
        dummyValue4 = sliderValue4;
        // ha az 5 csúszkát mozgatjuk
        sliderValue5 = (int)slider5.value;
        if(dummyValue5<sliderValue5)
        {
            blueHillIn.GetComponent<Text>().text = (slider5.maxValue - sliderValue5).ToString();
          
        }
        if (dummyValue5 > sliderValue5)
        {
            blueHillIn.GetComponent<Text>().text = (slider5.maxValue - sliderValue5).ToString();
            
        }
        dummyValue5 = sliderValue5;
        // ha az 6 csúszkát mozgatjuk
        sliderValue6 = (int)slider6.value;
        if(dummyValue6<sliderValue6)
        {
           opalIn.GetComponent<Text>().text = (slider6.maxValue - sliderValue6).ToString();
           
        }
        if (dummyValue6 > sliderValue6)
        {
            opalIn.GetComponent<Text>().text = (slider6.maxValue - sliderValue6).ToString();
            
        }
        dummyValue6 = sliderValue6;
        dummydropdownValue = dropdownValue;
    }
    public void acceptButtonClicked()
    {
        globalCrystal.blueC = (int.Parse(globalCrystal.blueC)-sliderValue3).ToString();
        globalCrystal.redC = (int.Parse(globalCrystal.redC) - sliderValue2).ToString();
        globalCrystal.purpelRombusC = (int.Parse(globalCrystal.purpelRombusC) - sliderValue4).ToString();
        globalCrystal.blueHillC = (int.Parse(globalCrystal.blueHillC) - sliderValue5).ToString();

        if (dropdownValue==2)
        {
            globalCrystal.purpleHillC = (int.Parse(globalCrystal.purpleHillC) - sliderValue1).ToString();
            globalCrystal.greenOaplC = (int.Parse(globalCrystal.greenOaplC)+int.Parse(opalOUT.GetComponent<Text>().text)).ToString();

        }
        if (dropdownValue==1)
        {
            globalCrystal.purpleHillC = (int.Parse(globalCrystal.purpleHillC)+int.Parse(purpleOUT.GetComponent<Text>().text)).ToString();
            globalCrystal.greenOaplC = (int.Parse(globalCrystal.greenOaplC) - sliderValue6).ToString();

        }
        StartCoroutine(marketFade_routine());
    }
    IEnumerator marketFade_routine()
    {
        marketPanel.GetComponent<Animation>().Play("marketFade");
        yield return new WaitForSeconds(1.2f);
        marketPanel.SetActive(false);
        menu.marketIsOpened = false;
        slider1.value = 0;
        slider2.value = 0;
        slider3.value = 0;
        slider4.value = 0;
        slider5.value = 0;
        slider6.value = 0;
    }
}
