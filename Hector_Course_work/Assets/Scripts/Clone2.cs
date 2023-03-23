using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone2 : MonoBehaviour
{
    public GameObject EaglePlane;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlanes(2);
    }

    // Update is called once per frame
    void CreatePlanes(int PlanesNum)
    {
        for(int i = 0; i < PlanesNum; i++)
        {
            GameObject Planeclone = Instantiate(EaglePlane, new Vector3(i, EaglePlane.transform.position.y, i), EaglePlane.transform.rotation);
        }
    }
}
