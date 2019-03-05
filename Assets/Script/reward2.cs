using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEditor;

public class reward2 : MonoBehaviour
{
    public GameObject erroPanel;
    public GameObject mesage;
    public GameObject imageRaw;
    public Texture[] frames;
    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //boots
                int rewardRandom = Random.Range(1, 100);
                if (rewardRandom % 11 == 0)
                {
                    int rewardBoots = Random.Range(0, 6);
                    int rewardBootsAmount = Random.Range(1800, 3600);
                    mesage.GetComponent<Text>().text = "You got " + (rewardBootsAmount%60) + " sec  boost";
                    switch (rewardBoots)
                    {
                        case 0:
                            globalbootS.boots1 = true;
                            globalbootS.time1 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[0];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");

                            break;
                        case 1:
                            globalbootS.boots2 = true;
                            globalbootS.time2 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[1];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                          
                            break;
                        case 2:
                            globalbootS.boots3 = true;
                            globalbootS.time3 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[2];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                           
                            break;
                        case 3:
                            globalbootS.boots4 = true;
                            globalbootS.time4 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[3];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            
                            break;
                        case 4:
                            globalbootS.boots5 = true;
                            globalbootS.time5 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[4];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            
                            break;
                        case 5:
                            globalbootS.boots6 = true;
                            globalbootS.time6 = rewardBootsAmount;
                            imageRaw.GetComponent<RawImage>().texture = frames[5];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            
                            break;
                    }
                }//allian
                else if (rewardRandom % 9 == 0)
                {
                    int rewardAllien = Random.Range(0, 6);
                    int rewardAllienAmount = Random.Range(1, 5);
                    mesage.GetComponent<Text>().text = "You got " + rewardAllienAmount + " Allian";
                    switch (rewardAllien)
                    {
                        case 0:
                            globalUfo.setUfo1D((int.Parse(globalUfo.getUfo1D()) + rewardAllienAmount).ToString());
                            imageRaw.GetComponent<RawImage>().texture = frames[0];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");

                            break;
                        case 1:
                            globalUfo.setUfo2D((int.Parse(globalUfo.getUfo2D()) + rewardAllienAmount).ToString());
                            imageRaw.GetComponent<RawImage>().texture = frames[1];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            globalUfo.ufo2E = true;
                            break;
                        case 2:
                            globalUfo.setUfo3D((int.Parse(globalUfo.getUfo3D()) + rewardAllienAmount).ToString());                       
                            imageRaw.GetComponent<RawImage>().texture = frames[2];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            globalUfo.ufo3E = true;
                            break;
                        case 3:
                            globalUfo.setUfo4D((int.Parse(globalUfo.getUfo4D()) + rewardAllienAmount).ToString());
                            imageRaw.GetComponent<RawImage>().texture = frames[3];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            globalUfo.ufo4E = true;
                            break;
                        case 4:
                            globalUfo.setUfo5D((int.Parse(globalUfo.getUfo5D()) + rewardAllienAmount).ToString());
                            imageRaw.GetComponent<RawImage>().texture = frames[4];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            globalUfo.ufo5E = true;
                            break;
                        case 5:
                            globalUfo.setUfo6D((int.Parse(globalUfo.getUfo6D()) + rewardAllienAmount).ToString());
                            imageRaw.GetComponent<RawImage>().texture = frames[5];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            globalUfo.ufo6E = true;
                            break;
                    }
                }//crystal
                else
                {
                    int rewardCristal = Random.Range(0, 6);
                    int rewardCristalAmount = Random.Range(1, 20);
                    mesage.GetComponent<Text>().text = "You got " + rewardCristalAmount + " crystal";
                    switch (rewardCristal)
                    {
                        case 0:
                            globalCrystal.purpleHillC = (int.Parse(globalCrystal.purpleHillC) + rewardCristalAmount).ToString();
                            imageRaw.GetComponent<RawImage>().texture = frames[6];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                        case 1:
                            globalCrystal.redC = (int.Parse(globalCrystal.redC) + rewardCristalAmount).ToString();
                            imageRaw.GetComponent<RawImage>().texture = frames[7];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                        case 2:
                            globalCrystal.blueC = (int.Parse(globalCrystal.blueC) + rewardCristalAmount).ToString();
                            imageRaw.GetComponent<RawImage>().texture = frames[8];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                        case 3:
                            globalCrystal.purpelRombusC = (int.Parse(globalCrystal.purpelRombusC) + rewardCristalAmount).ToString();

                            imageRaw.GetComponent<RawImage>().texture = frames[9];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                        case 4:
                            globalCrystal.blueHillC = (int.Parse(globalCrystal.blueHillC) + rewardCristalAmount).ToString();
                            imageRaw.GetComponent<RawImage>().texture = frames[10];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                        case 5:
                            globalCrystal.greenOaplC = (int.Parse(globalCrystal.greenOaplC) + rewardCristalAmount).ToString();
                            imageRaw.GetComponent<RawImage>().texture = frames[11];
                            erroPanel.SetActive(true);
                            erroPanel.GetComponent<Animation>().Play("errorPanel");
                            break;
                    }
                }
                
                Debug.Log("the reward is: " + rewardRandom);
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}