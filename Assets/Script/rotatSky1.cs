using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatSky1 : MonoBehaviour
{
    public float rotateSpeed = 1.1f;
    public GameObject loadButton;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        if(PlayerPrefs.GetInt("saved ")==1)
        {
            loadButton.active = true;
        }
        else
        {
            loadButton.active = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
       
    }
}
