using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour
{

    public GameObject EaglePlane;
    public float radius;
    public Transform Earth;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Earth);
        transform.LookAt(Earth, Vector3.left);
    }
}

