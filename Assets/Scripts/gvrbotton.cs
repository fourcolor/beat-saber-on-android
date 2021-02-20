using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gvrbotton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent gvrClick;
    public float totalTime;
    bool gvrStatus;
    public float gvrTimer;

    public AudioClip AudioClip_1;
    public AudioClip AudioClip_2;
    AudioSource audioSource;
    bool played=false;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            if(!played)
            {
                audioSource.PlayOneShot(AudioClip_1);
                played = true;
            }
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer >= totalTime)
        {
            audioSource.PlayOneShot(AudioClip_2);
            gvrClick.Invoke();
        }
    }
    public void GvrOn()
    {
        Debug.Log("1");
        gvrStatus = true;
    }
    public void Gvroff()
    {
        gvrStatus = false;
        played = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
