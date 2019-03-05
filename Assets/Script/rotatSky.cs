using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatSky : MonoBehaviour
{
    public float rotateSpeed = 1.1f;
   

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
      
    }
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
       
    }
}
