using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalbootS : MonoBehaviour
{
    public static bool boots1, boots2, boots3, boots4, boots5, boots6;
    public static bool isboots1, isboots2, isboots3, isboots4, isboots5, isboots6;
    public static int time1, time2, time3, time4, time5, time6;
    public GameObject ufo1, ufo2, ufo3, ufo4, ufo5, ufo6, opalBoots,message,erroPanel,imageRaw;
    public Texture2D othericon;

    // Update is called once per frame
    void Update()
    {
       if(boots1)
        {
            if (!isboots1)
            {
                StartCoroutine(bottsAllian1());
            }
            time1 -= 1;
            if(time1==0)
            {
                boots1 = false;
            }
        }
        if (boots2)
            if (!isboots2)
            {
                {
                    StartCoroutine(bottsAllian2());
                }
           
            time2 -= 1;
            if(time2==0)
            {
                boots2 = false;
            }
        }
        if (boots3)
        {
                    if (!isboots3)
                    {
                        StartCoroutine(bottsAllian3());
                    }
            
            time3 -= 1;
            if(time3==0)
            {
                boots3 = false;
            }
        }
        if (boots4)
        {
                        if (!isboots4)
                        {
                            StartCoroutine(bottsAllian4());
                        }
            
            time4 -= 1;
            if(time4==0)
            {
                boots4 = false;
            }
        }
        if (boots5)
        {
                            if (!isboots5)
                            {
                                StartCoroutine(bottsAllian5());
                            }
           
            time5 -= 1;
            if(time5==0)
            {
                boots5 = false;
            }
        }
        if (boots6)
        {
                                if (!isboots6)
                                {
                                    StartCoroutine(bottsAllian6());
                                }
            
            time6 -= 1;
            if(time6==0)
            {
                boots6 = false;
            }
        }
       
    }
    IEnumerator bottsAllian1()
    {
        isboots1 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo1Count += 100;
        isboots1 = false;
        yield return new WaitForSeconds(1);
        ufo1.GetComponent<Animation>().Play("ufo1Boots");


    } IEnumerator bottsAllian2()
    {
        isboots2 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo2Count += 200;
        isboots2 = false;
        yield return new WaitForSeconds(1);
        ufo2.GetComponent<Animation>().Play("ufo2Boots");
    }
    IEnumerator bottsAllian3()
    {
        isboots3 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo3Count += 300;
        isboots3 = false;
        yield return new WaitForSeconds(1);
        ufo3.GetComponent<Animation>().Play("ufo3Boots");

    }
    IEnumerator bottsAllian4()
    {
        isboots4 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo4Count += 500;
        isboots4 = false;
        yield return new WaitForSeconds(1);
        ufo4.GetComponent<Animation>().Play("ufo4Boots");

    }
    IEnumerator bottsAllian5()
    {
        isboots5 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo5Count += 600;
        isboots5 = false;
        yield return new WaitForSeconds(1);
        ufo5.GetComponent<Animation>().Play("ufo5Boots");

    }
    IEnumerator bottsAllian6()
    {
        isboots6 = true;
       yield return new WaitForSeconds(1);
        autoMine.ufo6Count += 800;
        isboots6 = false;
        yield return new WaitForSeconds(1);
        ufo6.GetComponent<Animation>().Play("ufo6Boots");
    }
    public void ufo1Click()
    {
        if (int.Parse(opalBoots.GetComponent<Text>().text) > 50)
        {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 50).ToString());
           opalBoots.GetComponent<Text>().text=globalCrystal.greenOaplC;
        boots1 = true;
        time1 = 1800;
        }
        else
        {
            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
            imageRaw.GetComponent<RawImage>().texture = othericon;
            erroPanel.SetActive(true);
            erroPanel.GetComponent<Animation>().Play("errorPanel");
        }
    }
    public void ufo2Click()
    {
            if (int.Parse(opalBoots.GetComponent<Text>().text) > 100)
            {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 100).ToString());
            opalBoots.GetComponent<Text>().text = globalCrystal.greenOaplC;
            boots2 = true;
        time2 = 1800;
            }
            else
            {
                message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
                imageRaw.GetComponent<RawImage>().texture = othericon;
                erroPanel.SetActive(true);
                erroPanel.GetComponent<Animation>().Play("errorPanel");
            }
        }
    public void ufo3Click()
    {
                if (int.Parse(opalBoots.GetComponent<Text>().text) > 200)
                {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 200).ToString());
            opalBoots.GetComponent<Text>().text = globalCrystal.greenOaplC;
            boots3 = true;
        time4 = 1800;
                }
                else
                {
                    message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
                    imageRaw.GetComponent<RawImage>().texture = othericon;
                    erroPanel.SetActive(true);
                    erroPanel.GetComponent<Animation>().Play("errorPanel");
                }
            }
    public void ufo4Click()
    {
                    if (int.Parse(opalBoots.GetComponent<Text>().text) > 300)
                    {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 300).ToString());
            opalBoots.GetComponent<Text>().text = globalCrystal.greenOaplC;
            boots4 = true;
        time4 = 1800;
                    }
                    else
                    {
                        message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
                        imageRaw.GetComponent<RawImage>().texture = othericon;
                        erroPanel.SetActive(true);
                        erroPanel.GetComponent<Animation>().Play("errorPanel");
                    }
                }
    public void ufo5Click()
    {
                        if (int.Parse(opalBoots.GetComponent<Text>().text) > 400)
                        {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 400).ToString());
            opalBoots.GetComponent<Text>().text = globalCrystal.greenOaplC;
            boots5 = true;
        time5 = 1800;
                        }
                        else
                        {
                            message.GetComponent<Text>().text = "You don't have enough crystals for the operation!";
                            imageRaw.GetComponent<RawImage>().texture = othericon;
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                        }
                    }
    public void ufo6Click()
    {
                            if (int.Parse(opalBoots.GetComponent<Text>().text) > 500)
                            {
            globalCrystal.setGreenOaplC((int.Parse(globalCrystal.greenOaplC) - 500).ToString());
            opalBoots.GetComponent<Text>().text = globalCrystal.greenOaplC;
            boots6 = true;
        time6 = 1800;
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
