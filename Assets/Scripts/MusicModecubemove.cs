using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModecubemove : MonoBehaviour
{
    MusicModeScore Score;
    public float addamount = -1;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<MusicModeScore>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 2;
        if(transform.position.z<1)
        {
            Score.AddScore(addamount);
            Destroy(gameObject);
            MusicModeScore.comboNum = 0;
        }
    }
}
