using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timecubemove : MonoBehaviour
{
    score Score, time, combo;
    public double addamount = -1;
    private float speed = 2;

    private TimeMiss timeMiss;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<score>();
        time = GameObject.FindGameObjectWithTag("time").GetComponent<score>();
        combo = GameObject.FindGameObjectWithTag("combo").GetComponent<score>();
        timeMiss = GameObject.FindGameObjectWithTag("Life").GetComponent<TimeMiss>();
    }

    // Update is called once per frame
    void Update()
    {
        float num = Score.getnum();
        if (time.currscore > 0)
            transform.position -= Time.deltaTime * transform.forward * speed * (1 + 0.01f * num);
        if (transform.position.z < 1)
        {
            timeMiss.MissMusic();
            if (transform.localScale.x == 0.4) time.AddScore(-5);
            if (combo.currscore != 0) combo.currscore = 0;
            time.UpdateScore();
            combo.UpdateScore();
            Destroy(gameObject);
        }
    }
}
