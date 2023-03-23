using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using Newtonsoft.Json.Linq;


public class API : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {

        Console.WriteLine($"API STARTED");
        Debug.Log("APISTARTED");
        string apiKey = "73d470f1a8dff5b98deb703da6ec1b23";
        // http://api.aviationstack.com/v1/flights?limit=10&access_key=73d470f1a8dff5b98deb703da6ec1b23
        //Construct the API endpoint URL, including the limit parameter
        string url = $"http://api.aviationstack.com/v1/flights?&access_key={apiKey}";

        // Send a GET request to the API endpoint
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";

        // Get the response from the API
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string responseText = reader.ReadToEnd();

        // Parse the response as a JSON object
        JObject flightData = JObject.Parse(responseText);
             
        Debug.Log(responseText);
        

    }
}
