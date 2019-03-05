using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public GameObject erroPanel;
    public GameObject mesage;
    public GameObject imageRaw;
    public Texture frames;
   
    public void saveClicked()
    {
        if(int.Parse(globalCrystal.greenOaplC)>=10)
        {
            globalCrystal.greenOaplC= (int.Parse(globalCrystal.greenOaplC)-10).ToString();
            PlayerPrefs.SetInt("isUfo1Mining", autoMine.isUfo1Mining?1:0);
            PlayerPrefs.SetInt("isUfo2Mining", autoMine.isUfo2Mining ? 1 : 0);
            PlayerPrefs.SetInt("isUfo3Mining", autoMine.isUfo3Mining ? 1 : 0);
            PlayerPrefs.SetInt("isUfo4Mining", autoMine.isUfo4Mining ? 1 : 0);
            PlayerPrefs.SetInt("isUfo5Mining", autoMine.isUfo5Mining ? 1 : 0);
            PlayerPrefs.SetInt("isUfo6Mining", autoMine.isUfo6Mining ? 1 : 0);
            PlayerPrefs.SetString("purpleHillCystal", globalCrystal.purpleHillC);
            PlayerPrefs.SetString("redCystal", globalCrystal.redC);
            PlayerPrefs.SetString("blueCystal", globalCrystal.blueC);
            PlayerPrefs.SetString("purpleRombusCystal", globalCrystal.purpelRombusC);
            PlayerPrefs.SetString("blueHillCystal", globalCrystal.blueHillC);
            PlayerPrefs.SetString("greenCystal", globalCrystal.greenOaplC);
            PlayerPrefs.SetString("ufo1P",globalUfo.ufo1P);
            PlayerPrefs.SetString("ufo1D",globalUfo.ufo1D);
            PlayerPrefs.SetString("ufo1Ar",globalUfo.ufo1Ar);
            PlayerPrefs.SetInt("ufo1E",globalUfo.ufo1E ? 1 : 0);
            PlayerPrefs.SetString("ufo2P",globalUfo.ufo2P);
            PlayerPrefs.SetString("ufo2D",globalUfo.ufo2D);
            PlayerPrefs.SetString("ufo2Ar",globalUfo.ufo2Ar);
            PlayerPrefs.SetInt("ufo2E",globalUfo.ufo2E ? 1 : 0);
            PlayerPrefs.SetString("ufo3P",globalUfo.ufo3P);
            PlayerPrefs.SetString("ufo3D",globalUfo.ufo3D);
            PlayerPrefs.SetString("ufo3Ar",globalUfo.ufo3Ar);
            PlayerPrefs.SetInt("ufo3E",globalUfo.ufo3E ? 1 : 0);
            PlayerPrefs.SetString("ufo4P",globalUfo.ufo4P);
            PlayerPrefs.SetString("ufo4D",globalUfo.ufo4D);
            PlayerPrefs.SetString("ufo4Ar",globalUfo.ufo4Ar);
            PlayerPrefs.SetInt("ufo4E",globalUfo.ufo4E ? 1 : 0);
            PlayerPrefs.SetString("ufo5P",globalUfo.ufo5P);
            PlayerPrefs.SetString("ufo5D",globalUfo.ufo5D);
            PlayerPrefs.SetString("ufo5Ar",globalUfo.ufo5Ar);
            PlayerPrefs.SetInt("ufo5E",globalUfo.ufo5E ? 1 : 0);
            PlayerPrefs.SetString("ufo6P",globalUfo.ufo6P);
            PlayerPrefs.SetString("ufo6D",globalUfo.ufo6D);
            PlayerPrefs.SetString("ufo6Ar",globalUfo.ufo6Ar);
            PlayerPrefs.SetInt("ufo6E",globalUfo.ufo6E ? 1 : 0);
            PlayerPrefs.SetInt("boots1", globalbootS.boots1 ? 1 : 0);
            PlayerPrefs.SetInt("time1", globalbootS.time1);
            PlayerPrefs.SetInt("boots2", globalbootS.boots2 ? 1 : 0);
            PlayerPrefs.SetInt("time2", globalbootS.time2);
            PlayerPrefs.SetInt("boots3", globalbootS.boots3 ? 1 : 0);
            PlayerPrefs.SetInt("time3", globalbootS.time3);
            PlayerPrefs.SetInt("boots4", globalbootS.boots4 ? 1 : 0);
            PlayerPrefs.SetInt("time4", globalbootS.time4);
            PlayerPrefs.SetInt("boots5", globalbootS.boots5 ? 1 : 0);
            PlayerPrefs.SetInt("time5", globalbootS.time5);
            PlayerPrefs.SetInt("boots6", globalbootS.boots6 ? 1 : 0);
            PlayerPrefs.SetInt("time6", globalbootS.time6);
            PlayerPrefs.SetInt("volumefor", (int)volume.musicVolume);
            PlayerPrefs.SetString("timeSaved", System.DateTime.UtcNow.ToString());
            PlayerPrefs.SetInt("saved", 1);
            mesage.GetComponent<Text>().text ="Game Saved!";
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }
        else
        {
            mesage.GetComponent<Text>().text ="You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = frames;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }
    }
}
