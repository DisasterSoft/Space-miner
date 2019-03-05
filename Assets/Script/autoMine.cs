using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autoMine : MonoBehaviour
{
    public int ufoMine1, ufoMine2, ufoMine3, ufoMine4, ufoMine5, ufoMine6;
    public  int ufo1CountDumy;
    public static int ufo1Count, ufo2Count, ufo3Count, ufo4Count, ufo5Count, ufo6Count;
    public int ufo1Time, ufo2Time, ufo3Time, ufo4Time, ufo5Time, ufo6Time;
    public static bool isUfo1Mining = false;
    public static bool isUfo2Mining = false;
    public static bool isUfo3Mining = false;
    public static bool isUfo4Mining = false;
    public static bool isUfo5Mining = false;
    public static bool isUfo6Mining = false;

    public Slider ufo1S, ufo2S, ufo3S, ufo4S, ufo5S, ufo6S;//slider
    public float progress1, progress2, progress3, progress4, progress5, progress6;
    public GameObject sliderText1, sliderText2, sliderText3, sliderText4, sliderText5, sliderText6;
    public void Start()
    {
        ufo1Count = ufo2Count = ufo3Count = ufo4Count = ufo5Count = ufo6Count = 1;
        ufo1Time = 1800;
        ufo2Time = 3600;
        ufo3Time = 18000;
        ufo4Time = 36000;
        ufo5Time = 108000;
        ufo6Time = 1728000;
    }
    // Update is called once per frame
    void Update()
    {
        if (globalUfo.ufo1E)
        {
            ufo1CountDumy = ufoMine1;
            ufoMine1 = int.Parse(globalUfo.ufo1D);
            if (!isUfo1Mining)
            {
                isUfo1Mining = true;

            }
            else
            {
                StartCoroutine(ufo1Minig());
            }
        }
        if (globalUfo.ufo2E)
        {
            ufoMine2 = int.Parse(globalUfo.ufo2D);
            if (!isUfo2Mining)
            {
                isUfo2Mining = true;

            }
            else
            {
                StartCoroutine(ufo2Minig());
            }
        }
        if (globalUfo.ufo3E)
        {
            ufoMine3 = int.Parse(globalUfo.ufo3D);
            if (!isUfo3Mining)
            {
                isUfo3Mining = true;

            }
            else
            {
                StartCoroutine(ufo3Minig());
            }
        }
            if (globalUfo.ufo4E)
            {
                ufoMine4 = int.Parse(globalUfo.ufo4D);
                if (!isUfo4Mining)
                {
                    isUfo4Mining = true;

                }
                else
                {
                    StartCoroutine(ufo4Minig());
                }
            }
            if (globalUfo.ufo5E)
            {
                ufoMine5 = int.Parse(globalUfo.ufo5D);
                if (!isUfo5Mining)
                {
                    isUfo5Mining = true;

                }
                else
                {
                    StartCoroutine(ufo5Minig());
                }
            }
            if (globalUfo.ufo6E)
            {
                ufoMine6 = int.Parse(globalUfo.ufo6D);
                if (!isUfo6Mining)
                {
                    isUfo6Mining = true;

                }
                else
                {
                    StartCoroutine(ufo6Minig());
                }
            }

        }
    IEnumerator ufo1Minig()
    {
        ufo1Count += 1;
        if(ufo1Count>=ufo1Time)
        {
            int seged = int.Parse(globalCrystal.purpleHillC);
            int ossz = seged + ufoMine1;
            globalCrystal.setPurpleHillC(ossz.ToString());
            isUfo1Mining = false;
            ufo1Count = 0;
            
        }
        progress1 = Mathf.Clamp01(ufo1Count / (float)ufo1Time);
        ufo1S.value = progress1;
        sliderText1.GetComponent<Text>().text = Mathf.Ceil(progress1 * 100) + "%";
        yield return new WaitForSeconds(1);
       
    }

    IEnumerator ufo2Minig()
    {
        ufo2Count += 1;
        if (ufo2Count >= ufo2Time)
        {
            int seged = int.Parse(globalCrystal.redC);
            int ossz = seged + ufoMine2;
            globalCrystal.setRedC(ossz.ToString());
            isUfo2Mining = false;
            ufo2Count = 0;

        }
        progress2 = Mathf.Clamp01(ufo2Count / (float)ufo2Time);
        ufo2S.value = progress2;
        sliderText2.GetComponent<Text>().text = Mathf.Ceil(progress2 * 100) + "%";
        yield return new WaitForSeconds(1);

    }
    IEnumerator ufo3Minig()
    {
        ufo3Count += 1;
        if (ufo3Count >= ufo3Time)
        {
            int seged = int.Parse(globalCrystal.blueC);
            int ossz = seged + ufoMine3;
            globalCrystal.setBlueC(ossz.ToString());
            isUfo3Mining = false;
            ufo3Count = 0;

        }
        progress3 = Mathf.Clamp01(ufo3Count / (float)ufo3Time);
        ufo3S.value = progress3;
        sliderText3.GetComponent<Text>().text = Mathf.Ceil(progress3 * 100) + "%";
        yield return new WaitForSeconds(1);

    }
    IEnumerator ufo4Minig()
    {
        ufo4Count += 1;
        if (ufo4Count >= ufo4Time)
        {
            int seged = int.Parse(globalCrystal.purpelRombusC);
            int ossz = seged + ufoMine4;
            globalCrystal.setPurpelRombusC(ossz.ToString());
            isUfo4Mining = false;
            ufo4Count = 0;

        }
        progress4 = Mathf.Clamp01(ufo4Count / (float)ufo4Time);
        ufo4S.value = progress4;
        sliderText4.GetComponent<Text>().text = Mathf.Ceil(progress4 * 100) + "%";
        yield return new WaitForSeconds(1);

    }
    IEnumerator ufo5Minig()
    {
        ufo5Count += 1;
        if (ufo5Count >= ufo5Time)
        {
            int seged = int.Parse(globalCrystal.blueHillC);
            int ossz = seged + ufoMine5;
            globalCrystal.setBlueHillC(ossz.ToString());
            isUfo5Mining = false;
            ufo5Count = 0;

        }
        progress5 = Mathf.Clamp01(ufo5Count / (float)ufo5Time);
        ufo5S.value = progress5;
        sliderText5.GetComponent<Text>().text = Mathf.Ceil(progress5 * 100) + "%";
        yield return new WaitForSeconds(1);

    }
    IEnumerator ufo6Minig()
    {
        ufo6Count += 1;
        if (ufo6Count >= ufo6Time)
        {
            int seged = int.Parse(globalCrystal.greenOaplC);
            int ossz = seged + ufoMine6;
            globalCrystal.setGreenOaplC(ossz.ToString());
            isUfo6Mining = false;
            ufo6Count = 0;

        }
        progress6 = Mathf.Clamp01(ufo6Count / (float)ufo6Time);
        ufo6S.value = progress6;
        sliderText6.GetComponent<Text>().text = Mathf.Ceil(progress6 * 100) + "%";
        yield return new WaitForSeconds(1);

    }

}
