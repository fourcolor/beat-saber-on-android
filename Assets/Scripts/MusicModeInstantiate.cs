using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModeInstantiate : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    
    float timer = 0;
    static public float passingTime = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat && passingTime < 67) //音樂快結束
        {
            GameObject cube = Instantiate(cubes[0], points[Random.Range(0, 3)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        timer += Time.deltaTime;
        passingTime += Time.deltaTime;
    }
    public float GetPassingTime()
    {
        return passingTime;
    }
}
