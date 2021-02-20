using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEndGameUI : MonoBehaviour
{
    public List<GameObject> gob = new List<GameObject>();
    score time;
    void Start()
    {
        foreach (GameObject g in gob)
        {
            g.SetActive(false);
        }


        time = GameObject.FindGameObjectWithTag("time").GetComponent<score>();



    }

    // Update is called once per frame
    void Update()
    {
        if (time.getnum() <= 0)
        {
            foreach (GameObject g in gob)
            {
                g.SetActive(true);
            }

        }
    }
}
