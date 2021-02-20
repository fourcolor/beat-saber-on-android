using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEndGameUI : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> gob = new List<GameObject>();
    MusicModeInstantiate M;
    score time;
    GameObject c;
    void Start()
    {
        foreach (GameObject g in gob)
        {
            g.SetActive(false);
        }
        M = GameObject.FindGameObjectWithTag("CubeGen").GetComponent<MusicModeInstantiate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (M.GetPassingTime() >= 80)
        {
            foreach (GameObject g in gob)
            {
                g.SetActive(true);
            }
        }
    }
}
