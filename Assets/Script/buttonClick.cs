using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour
{
    public GameObject button1, button2, button3, button4, button5, button6,erroPanel,message,imageRaw;
    public Texture2D othericon;
    // Start is called before the first frame update
    private void Start()
    {
        message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
        imageRaw.GetComponent<RawImage>().texture = othericon;
    }
    public void clickTheButton1()
    {
       if(int.Parse(globalCrystal.purpleHillC)>=int.Parse(globalUfo.ufo1Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo1Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo1Ar = (int.Parse(globalUfo.ufo1Ar)*2).ToString();
            globalUfo.setUfo1D((int.Parse(globalUfo.getUfo1D())+1).ToString());
            globalUfo.setUfo1P(globalUfo.getUfo1D());
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
    public void clickTheButton2()
    {
        if (int.Parse(globalCrystal.purpleHillC) >= int.Parse(globalUfo.ufo2Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo2Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo2Ar = (int.Parse(globalUfo.ufo2Ar) * 2).ToString();
            globalUfo.setUfo2D((int.Parse(globalUfo.getUfo2D()) + 1).ToString());
            globalUfo.setUfo2P(globalUfo.getUfo2D());
            globalUfo.ufo2E = true;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
    public void clickTheButton3()
    {
        if (int.Parse(globalCrystal.purpleHillC) >= int.Parse(globalUfo.ufo3Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo3Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo3Ar = (int.Parse(globalUfo.ufo3Ar) * 2).ToString();
            globalUfo.setUfo3D((int.Parse(globalUfo.getUfo3D()) + 1).ToString());
            globalUfo.setUfo3P(globalUfo.getUfo3D());
            globalUfo.ufo3E = true;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
    public void clickTheButton4()
    {
        if (int.Parse(globalCrystal.purpleHillC) >= int.Parse(globalUfo.ufo4Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo4Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo4Ar = (int.Parse(globalUfo.ufo4Ar) * 2).ToString();
            globalUfo.setUfo4D((int.Parse(globalUfo.getUfo4D()) + 1).ToString());
            globalUfo.setUfo4P(globalUfo.getUfo4D());
            globalUfo.ufo4E = true;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
    public void clickTheButton5()
    {
        if (int.Parse(globalCrystal.purpleHillC) >= int.Parse(globalUfo.ufo5Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo5Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo5Ar = (int.Parse(globalUfo.ufo5Ar) * 2).ToString();
            globalUfo.setUfo5D((int.Parse(globalUfo.getUfo5D()) + 1).ToString());
            globalUfo.setUfo5P(globalUfo.getUfo5D());
            globalUfo.ufo5E = true;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
    public void clickTheButton6()
    {
        if (int.Parse(globalCrystal.purpleHillC) >= int.Parse(globalUfo.ufo6Ar))
        {
            int osszeg = int.Parse(globalCrystal.purpleHillC) - int.Parse(globalUfo.ufo6Ar);
            globalCrystal.setPurpleHillC(osszeg.ToString());
            globalUfo.ufo6Ar = (int.Parse(globalUfo.ufo6Ar) * 2).ToString();
            globalUfo.setUfo6D((int.Parse(globalUfo.getUfo6D()) + 1).ToString());
            globalUfo.setUfo6P(globalUfo.getUfo6D());
            globalUfo.ufo6E = true;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }


    }
}
