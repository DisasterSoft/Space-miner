using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globaSetter : MonoBehaviour
{
   
    public GameObject erroPanel,menuPanel,marketPanel,bootsPanel,settingPanel,message, imageRaw;
    public Texture crystal;
    // Start is called before the first frame update
    void Start()
    {
        if (goTheScene4.isLoaded)
        {
            globalCrystal.setPurpleHillC(PlayerPrefs.GetString("purpleHillCystal"));
            globalCrystal.setRedC(PlayerPrefs.GetString("redCystal"));
            globalCrystal.setBlueC(PlayerPrefs.GetString("blueCystal"));
            globalCrystal.setPurpelRombusC(PlayerPrefs.GetString("purpleRombusCystal"));
            globalCrystal.setBlueHillC(PlayerPrefs.GetString("blueHillCystal"));
            globalCrystal.setGreenOaplC(PlayerPrefs.GetString("greenCystal"));
            globalUfo.setUfo1D(PlayerPrefs.GetString("ufo1D"));
            globalUfo.setUfo1P(PlayerPrefs.GetString("ufo1P"));
            globalUfo.setUfo2D(PlayerPrefs.GetString("ufo2D"));
            globalUfo.setUfo2P(PlayerPrefs.GetString("ufo2P"));
            globalUfo.setUfo3D(PlayerPrefs.GetString("ufo3D"));
            globalUfo.setUfo3P(PlayerPrefs.GetString("ufo3P"));
            globalUfo.setUfo4D(PlayerPrefs.GetString("ufo4D"));
            globalUfo.setUfo4P(PlayerPrefs.GetString("ufo4P"));
            globalUfo.setUfo5D(PlayerPrefs.GetString("ufo5D"));
            globalUfo.setUfo5P(PlayerPrefs.GetString("ufo5P"));
            globalUfo.setUfo6D(PlayerPrefs.GetString("ufo6D"));
            globalUfo.setUfo6P(PlayerPrefs.GetString("ufo6P"));
            globalUfo.ufo1E = true;
            globalUfo.ufo2E = PlayerPrefs.GetInt("ufo2E") == 1 ? true : false;
            globalUfo.ufo3E = PlayerPrefs.GetInt("ufo3E") == 1 ? true : false;
            globalUfo.ufo4E = PlayerPrefs.GetInt("ufo4E") == 1 ? true : false;
            globalUfo.ufo5E = PlayerPrefs.GetInt("ufo5E") == 1 ? true : false;
            globalUfo.ufo6E = PlayerPrefs.GetInt("ufo6E") == 1 ? true : false;
            globalUfo.ufo1Ar = PlayerPrefs.GetString("ufo1Ar");
            globalUfo.ufo2Ar = PlayerPrefs.GetString("ufo2Ar");
            globalUfo.ufo3Ar = PlayerPrefs.GetString("ufo3Ar");
            globalUfo.ufo4Ar = PlayerPrefs.GetString("ufo4Ar");
            globalUfo.ufo5Ar = PlayerPrefs.GetString("ufo5Ar");
            globalUfo.ufo6Ar = PlayerPrefs.GetString("ufo6Ar");
            globalbootS.boots1= PlayerPrefs.GetInt("boots1") == 1 ? true : false;
            globalbootS.boots2= PlayerPrefs.GetInt("boots2") == 1 ? true : false;
            globalbootS.boots3= PlayerPrefs.GetInt("boots3") == 1 ? true : false;
            globalbootS.boots4= PlayerPrefs.GetInt("boots4") == 1 ? true : false;
            globalbootS.boots5= PlayerPrefs.GetInt("boots5") == 1 ? true : false;
            globalbootS.boots6= PlayerPrefs.GetInt("boots6") == 1 ? true : false;
            globalbootS.time1 = PlayerPrefs.GetInt("time1");
            globalbootS.time2 = PlayerPrefs.GetInt("time2");
            globalbootS.time3 = PlayerPrefs.GetInt("time3");
            globalbootS.time4 = PlayerPrefs.GetInt("time4");
            globalbootS.time5 = PlayerPrefs.GetInt("time5");
            globalbootS.time6 = PlayerPrefs.GetInt("time6");  
            volume.musicVolume = PlayerPrefs.GetInt("volumefor");
            autoMine.isUfo1Mining= PlayerPrefs.GetInt("isUfo1Mining") == 1 ? true : false;
            autoMine.isUfo2Mining = PlayerPrefs.GetInt("isUfo2Mining") == 1 ? true : false;
            autoMine.isUfo3Mining = PlayerPrefs.GetInt("isUfo3Mining") == 1 ? true : false;
            autoMine.isUfo4Mining = PlayerPrefs.GetInt("isUfo4Mining") == 1 ? true : false;
            autoMine.isUfo5Mining = PlayerPrefs.GetInt("isUfo5Mining") == 1 ? true : false;
            autoMine.isUfo6Mining = PlayerPrefs.GetInt("isUfo6Mining") == 1 ? true : false;
            System.DateTime oDate = System.DateTime.Parse(PlayerPrefs.GetString("timeSaved"));
            System.DateTime nowDate=System.DateTime.UtcNow;
            double secs = (oDate - nowDate).TotalSeconds;
            int ossz = (int)secs % 30;
            ossz += (int)secs % 60;
            ossz += (int)secs % 300;
            ossz += (int)secs % 600;
            ossz += (int)secs % 28800;
            message.GetComponent<Text>().text = "You've been away for"+(secs % 60) +" minutes, during that time, "+ (Mathf.Ceil(ossz*(float)0.01))+" crystals have been produced";
            imageRaw.GetComponent<RawImage>().texture = crystal;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
            globalCrystal.setPurpleHillC((int.Parse(globalCrystal.purpleHillC) + Mathf.Ceil(ossz * (float)0.01)).ToString());
        }
        else
        {
            globalCrystal.setPurpleHillC("0");
            globalCrystal.setRedC("0");
            globalCrystal.setBlueC("0");
            globalCrystal.setPurpelRombusC("0");
            globalCrystal.setBlueHillC("0");
            globalCrystal.setGreenOaplC("0");
            globalUfo.setUfo1D("1");
            globalUfo.setUfo1P("1");
            globalUfo.setUfo2D("0");
            globalUfo.setUfo2P("0");
            globalUfo.setUfo3D("0");
            globalUfo.setUfo3P("0");
            globalUfo.setUfo4D("0");
            globalUfo.setUfo4P("0");
            globalUfo.setUfo5D("0");
            globalUfo.setUfo5P("0");
            globalUfo.setUfo6D("0");
            globalUfo.setUfo6P("0");
            globalUfo.ufo1E = true;
            globalUfo.ufo2E = false;
            globalUfo.ufo3E = false;
            globalUfo.ufo4E = false;
            globalUfo.ufo5E = false;
            globalUfo.ufo6E = false;
            globalUfo.ufo1Ar ="1";
             globalUfo.ufo2Ar ="5";
             globalUfo.ufo3Ar ="1000";
             globalUfo.ufo4Ar ="15000";
             globalUfo.ufo5Ar ="100000";
             globalUfo.ufo6Ar ="500000";
        }
        erroPanel.SetActive(false);
        menuPanel.SetActive(false);
        marketPanel.SetActive(false);
        bootsPanel.SetActive(false);
        settingPanel.SetActive(false);
    }

}
