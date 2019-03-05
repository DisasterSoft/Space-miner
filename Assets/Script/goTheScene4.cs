using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goTheScene4 : MonoBehaviour
{
    public static bool isLoaded = false;
    public void nextNew()
    {
        isLoaded = false;
        SceneManager.LoadScene(3);
    }
    public void nextLoad()
    {
        isLoaded = true;
        SceneManager.LoadScene(3);
    }
}
