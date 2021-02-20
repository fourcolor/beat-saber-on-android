using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessEndGameUI : MonoBehaviour
{
    public List<GameObject> gob = new List<GameObject>();
    private EndlessModeLife life;
    void Start()
    {
        foreach (GameObject g in gob)
        {
            g.SetActive(false);
        }


        life = GameObject.FindGameObjectWithTag("Life").GetComponent<EndlessModeLife>();



    }

    // Update is called once per frame
    void Update()
    {
        if (life.life <= 0)
        {
            foreach (GameObject g in gob)
            {
                g.SetActive(true);
            }
        }
            
    }
}
