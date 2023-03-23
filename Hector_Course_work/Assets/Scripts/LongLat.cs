// Import necessary libraries
using System.Collections.Generic; // For using Lists
using System.IO; // For file writing
using UnityEngine; // For Unity Engine


// Declare a class named "LongLat" derived from MonoBehaviour
public class LongLat : MonoBehaviour
{
    // Declare public fields
    public float radius; // The radius of the sphere
    public Transform marker; // The marker object to be placed
    public Transform parent; // The parent object of all markers


    public float rndlongi; // The random longitude of each marker
    public float rndlat; // The random latitude of each marker

    public List<Vector2> markerLocations; // A list to store the locations of all markers

    // Use this for initialization
    public void Start()
    {
        // Set the resolution of the screen
        Screen.SetResolution(1078, 524, false);

        // Create a new list to store the marker locations
        markerLocations = new List<Vector2>();

        // Create 3 rows of 10 markers each
        int i = 0;
        while (i < 3)
        {
            int j = 0;
            while (j < 10)
            {
                // Generate random longitude and latitude
                rndlongi = Random.Range(-180, 180);
                rndlat = Random.Range(-90, 90);

                // Convert longitude and latitude from degrees to radians
                float templongi = rndlongi * Mathf.PI / 180;
                float templat = rndlat * Mathf.PI / 180;

                // Calculate the x, y, and z positions of the marker on the sphere
                float Xpos = radius * Mathf.Cos(templat) * Mathf.Cos(templongi);
                float Ypos = radius * Mathf.Cos(templat) * Mathf.Sin(templongi);
                float Zpos = radius * Mathf.Sin(templat);

                // Set the position of the marker
                marker.position = new Vector3(Xpos, Zpos, Ypos);

                // Instantiate the marker as a child of the parent object
                Instantiate(marker, parent);

                // Add the location of the marker to the list
                markerLocations.Add(new Vector2(rndlongi, rndlat));

                j++;
            }
            i++;
        }

        // Save the locations of all markers to a file
        SaveLocations();
    }

    // Write the locations of all markers to a file
    private void SaveLocations()
    {
        // Set the path of the file to be created
        string path = Application.dataPath + "/marker_locations.txt";

        // Open the file for writing
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            // Write the location of each marker to the file
            foreach (Vector2 location in markerLocations)
            {
                writer.WriteLine("Longitude: " + location.x + " Latitude: " + location.y);

                // Log the location of each marker to the console
                Debug.Log("Longitude: " + location.x + " Latitude: " + location.y);
            }
        }
    }
}