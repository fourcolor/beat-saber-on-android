using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessModeCubeMove : MonoBehaviour
{
    private EndlessModeLife life;
    private float speed = 2;
    private EndlessModeSurvivedTime timer;
    private int level=1;
    // Start is called before the first frame update
    void Start()
    {
        life = GameObject.FindGameObjectWithTag("Life").GetComponent<EndlessModeLife>();
        timer = GameObject.FindGameObjectWithTag("SurvivedTime").GetComponent<EndlessModeSurvivedTime>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.currstime>=10*level)
        {
            speed += 0.3f;
            level += 1;
        }
        if(life.life>0)
        transform.position -= Time.deltaTime * transform.forward * speed;

        if (transform.position.z<1)
        {
            life.MinusLife();
            Destroy(gameObject);
        }
    }
}
