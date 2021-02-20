using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class saber : MonoBehaviour
{
    // Start is called before the first frame update
    score Score;
    public float addamount = 1;
    public LayerMask layer;
    public Vector3 prePos;
    public score score;
    public Material materialAfterSlice;
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
        {
            if (Vector3.Angle(transform.position - prePos, hit.transform.up) > 130)
            {
                Score.AddScore(addamount);
                SlicedHull slicedObject = SliceObject(hit.transform.gameObject, materialAfterSlice);

                GameObject upperHullGameobject = slicedObject.CreateUpperHull(hit.transform.gameObject, materialAfterSlice);
                GameObject lowerHullGameobject = slicedObject.CreateLowerHull(hit.transform.gameObject, materialAfterSlice);
                upperHullGameobject.transform.position = hit.transform.transform.position;
                lowerHullGameobject.transform.position = hit.transform.transform.position;

                MakeItPhysical(upperHullGameobject);
                MakeItPhysical(lowerHullGameobject);

                Destroy(hit.transform.gameObject);
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
        return obj.Slice(transform.position, transform.up, crossSectionMaterial);
    }

}
