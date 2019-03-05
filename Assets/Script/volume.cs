using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class volume : MonoBehaviour
{

    // Reference to Audio Source component
    private AudioSource audioSrc;
    public Slider slider;
    public GameObject volumeString;

    // Music volume variable that will be modified
    // by dragging slider knob
    public static float musicVolume = 0.3f;

    // Use this for initialization
    void Start()
    {

        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = musicVolume;
        slider.value = musicVolume;
        volumeString.GetComponent<Text>().text = (Mathf.Ceil( musicVolume*100)).ToString();
    }

    // Update is called once per frame
    void Update()
    {

        // Setting volume option of Audio Source to be equal to musicVolume
        audioSrc.volume = musicVolume;
        volumeString.GetComponent<Text>().text = (Mathf.Ceil(musicVolume *100)).ToString();
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}