using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class imageClick : MonoBehaviour
{
    public GameObject  ufoImage1, ufoImage2, ufoImage3, ufoImage4, ufoImage5, ufoImage6;
    public void ufo1Clicked()
    {
        if (globalUfo.ufo1E)
        {
            
            autoMine.ufo1Count += 50;
        }
    }

    public void ufo2Clicked()
    {
        if (globalUfo.ufo2E)
        {
            autoMine.ufo2Count += 80;
        }
    }

    public void ufo3Clicked()
    {
        if (globalUfo.ufo3E)
        {
            autoMine.ufo3Count += 300;
        }
    }

    public void ufo4Clicked()
    {
        if (globalUfo.ufo4E)
        {
            autoMine.ufo4Count += 600;
        }
    }

    public void ufo5Clicked()
    {
        if (globalUfo.ufo5E)
        {
            autoMine.ufo5Count += 1500;
        }
    }

    public void ufo6Clicked()
    {
        if (globalUfo.ufo6E)
        {
            autoMine.ufo6Count += 5000;
        }
    }

}
