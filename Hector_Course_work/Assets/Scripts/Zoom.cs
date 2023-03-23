
using UnityEngine;


public class Zoom : MonoBehaviour
{

    [SerializeField] Camera cam;

    public float zoom = 10f;
   
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(cam.orthographic)
        {
          cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * zoom;

        }
        else
        {
            cam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * zoom;
        }
   
    }

    
}
