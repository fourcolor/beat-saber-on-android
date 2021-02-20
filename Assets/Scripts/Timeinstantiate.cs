using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeinstantiate : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    public int red;
    private float timer=0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            red = Random.Range(0, 20);
            GameObject cube = (red < 3) ? Instantiate(cubes[1], points[Random.Range(0, 3)]) : Instantiate(cubes[0], points[Random.Range(0, 3)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}
