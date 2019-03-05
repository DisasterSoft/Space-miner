using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalCrystal : MonoBehaviour
{
    public static string purpleHillC, redC, blueC, purpelRombusC, blueHillC, greenOaplC;
    public  GameObject purpleHillCG, redCG, blueCG, purpelRombusCG, blueHillCG, greenOaplCG;
  
    //get/set purpelHillC
    public string getPurpleHillC()
    {
        return purpleHillC;
    }
    public static void setPurpleHillC(string x)
    {
        purpleHillC = x;
        
    }

    //get/set redC
    public string getRedC()
    {
        return redC;
    }
    public static void setRedC(string x)
    {
        redC = x;
        
    }

    //get/set blueC
    public string getBblueC()
    {
        return blueC;
    }
    public static void setBlueC(string x)
    {
        blueC = x;
       
    }

    //get/set PurpelRombusC
    public string getPurpelRombusC()
    {
        return purpelRombusC;
    }
    public static void setPurpelRombusC(string x)
    {
        purpelRombusC = x;
       
    }

    //get/set  blueHillC
    public string getBlueHillC()
    {
        return blueHillC;
    }
    public static void setBlueHillC(string x)
    {
        blueHillC = x;
        
    }

    //get/set greenOapl
    public string getGreenOaplC()
    {
        return greenOaplC;
    }
    public static void setGreenOaplC(string x)
    {
        greenOaplC = x;
       
    }

   void Start()
    {
        purpleHillCG.GetComponent<Text>().text = purpleHillC;
        redCG.GetComponent<Text>().text = redC;
        blueCG.GetComponent<Text>().text =blueC;
        purpelRombusCG.GetComponent<Text>().text = purpelRombusC;
        blueHillCG.GetComponent<Text>().text = blueHillC;
        greenOaplCG.GetComponent<Text>().text =greenOaplC;
    }

    // Update is called once per frame
    void Update()
    {
        purpleHillCG.GetComponent<Text>().text = purpleHillC;
        redCG.GetComponent<Text>().text = redC;
        blueCG.GetComponent<Text>().text = blueC;
        purpelRombusCG.GetComponent<Text>().text = purpelRombusC;
        blueHillCG.GetComponent<Text>().text = blueHillC;
        greenOaplCG.GetComponent<Text>().text = greenOaplC;

    }
}
