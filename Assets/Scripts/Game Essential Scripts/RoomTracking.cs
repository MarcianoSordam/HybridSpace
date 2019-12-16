using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTracking : MonoBehaviour
{
    private GameObject lookHere;
    // Start is called before the first frame update
    void Start()
    {
        lookHere = GameObject.FindGameObjectWithTag("TrackMe");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookHere.transform);
    }
}
