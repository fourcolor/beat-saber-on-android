using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EndlessModeGvrButton : MonoBehaviour {
    public Image imgCircle;
    public UnityEvent gvrClick;
    public float totalTime;
    bool gvrStatus;
    public float gvrTimer;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }
        if(gvrTimer>=totalTime)
        {
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
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
