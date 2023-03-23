using UnityEngine;

public class MarkerPlacement : MonoBehaviour
{
    public Transform sphere;
    public float radius = 10f;

    public void PlaceMarker(float longitude, float latitude)
    {
        float phi = (90f - latitude) * Mathf.Deg2Rad;
        float theta = (360f - longitude) * Mathf.Deg2Rad;

        Vector3 markerPosition = new Vector3(radius * Mathf.Sin(phi) * Mathf.Cos(theta), radius * Mathf.Cos(phi), radius * Mathf.Sin(phi) * Mathf.Sin(theta));

        GameObject marker = new GameObject("Marker");
        marker.transform.position = markerPosition;
        marker.transform.SetParent(sphere);
    }
}
