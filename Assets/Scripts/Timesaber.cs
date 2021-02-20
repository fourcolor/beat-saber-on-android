using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Timesaber : MonoBehaviour
{
    // Start is called before the first frame update
    score Score, time, combo;
    public float addamount = 1;
    public float count = 0;
    public int wait = 0;
    public LayerMask layer;
    public Vector3 prePos;
    public score score;
    public Material[] materialAfterSlice;

    public AudioClip beat;
    AudioSource audioSource;
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<score>();
        combo = GameObject.FindGameObjectWithTag("combo").GetComponent<score>();
        time = GameObject.FindGameObjectWithTag("time").GetComponent<score>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (time.currscore > 0)
            time.AddScore(Time.deltaTime * (-1));
        count++;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
        {
            if (Vector3.Angle(transform.position - prePos, hit.transform.up) > 130)
            {
                audioSource.PlayOneShot(beat);
                Score.AddScore(combo.currscore + addamount);
                if (combo.currscore == 0 && wait == 0) wait = 1;
                else
                {
                    combo.AddScore(1);
                    wait = 0;
                }
                if (hit.transform.gameObject.tag == "red")
                {
                    time.AddScore(5);
                    SlicedHull slicedObject = SliceObject(hit.transform.gameObject, materialAfterSlice[1]);

                    GameObject upperHullGameobject = slicedObject.CreateUpperHull(hit.transform.gameObject, materialAfterSlice[1]);
                    GameObject lowerHullGameobject = slicedObject.CreateLowerHull(hit.transform.gameObject, materialAfterSlice[1]);
                    upperHullGameobject.transform.position = hit.transform.transform.position;
                    lowerHullGameobject.transform.position = hit.transform.transform.position;

                    MakeItPhysical(upperHullGameobject);
                    MakeItPhysical(lowerHullGameobject);

                    Destroy(hit.transform.gameObject);
                }
                else
                {
                    SlicedHull slicedObject = SliceObject(hit.transform.gameObject, materialAfterSlice[0]);

                    GameObject upperHullGameobject = slicedObject.CreateUpperHull(hit.transform.gameObject, materialAfterSlice[0]);
                    GameObject lowerHullGameobject = slicedObject.CreateLowerHull(hit.transform.gameObject, materialAfterSlice[0]);
                    upperHullGameobject.transform.position = hit.transform.transform.position;
                    lowerHullGameobject.transform.position = hit.transform.transform.position;

                    MakeItPhysical(upperHullGameobject);
                    MakeItPhysical(lowerHullGameobject);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        prePos = transform.position;
    }
    private void MakeItPhysical(GameObject obj)
    {
        obj.AddComponent<MeshCollider>().convex = true;
        obj.AddComponent<Rigidbody>();
    }

    private SlicedHull SliceObject(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, Vector3.Normalize(Vector3.Cross(transform.position, prePos)), crossSectionMaterial);
    }

}
