using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessModeInstantiate : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float period;
    private EndlessModeSurvivedTime timer;
    private float gen_time =0;
    private int level = 1;
    // Use this for initialization
    void Start()
    {
        timer = GameObject.FindGameObjectWithTag("SurvivedTime").GetComponent<EndlessModeSurvivedTime>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.currstime>gen_time)
        {
            GameObject cube = Instantiate(cubes[0], points[Random.Range(0, 3)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            gen_time += period;
        }
        if (timer.currstime > level*10)
        {
            if (period > 0.5)
            {
                period -= 0.1f;
                level += 1;
            }
            
        }

    }
}
