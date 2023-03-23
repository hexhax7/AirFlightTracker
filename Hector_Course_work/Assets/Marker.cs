
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Marker : MonoBehaviour
{
    public Transform sphere;
    public float radius = 10f;
    public int numMarkers = 10;

    void Start()
    {
        for (int i = 0; i < numMarkers; i++)
        {
            float longitude = Random.Range(-180f, 180f);
            float latitude = Random.Range(-90f, 90f);
            PlaceMarker(longitude, latitude);
        }
    }

    public void PlaceMarker(float longitude, float latitude)
    {
        float phi = (90f - latitude) * Mathf.Deg2Rad;
        float theta = (360f - longitude) * Mathf.Deg2Rad;

        Vector3 markerPosition = new Vector3(radius * Mathf.Sin(phi) * Mathf.Cos(theta), radius * Mathf.Cos(phi), radius * Mathf.Sin(phi) * Mathf.Sin(theta));

        GameObject marker = new GameObject("Marker");
        marker.transform.position = markerPosition;
        marker.transform.SetParent(sphere);

        Debug.Log("Latitude: " + latitude + ", Longitude: " + longitude + ", Position: " + markerPosition);
    }
}
