using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTracking : MonoBehaviour
{
    private GameObject lookHere;
    void Start()
    {
        lookHere = GameObject.FindGameObjectWithTag("TrackMe");
        transform.LookAt(lookHere.transform);
    }

    void Update()
    {
        if(lookHere == null)
        {
        lookHere = GameObject.FindGameObjectWithTag("TrackMe");
        transform.LookAt(lookHere.transform);
        }
    }
}
