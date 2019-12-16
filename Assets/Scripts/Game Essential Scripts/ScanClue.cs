using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScanClue : MonoBehaviour
{
    private Camera camera;
    private Clue tempClue;

    [SerializeField]
    private Image scanUI;

    public float counter;

    bool canScan;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        scanUI.enabled = false;
        canScan = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Clue")
            {
                if(counter == 60 && !scanUI.enabled)
                {
                    scanUI.enabled = true;
                    canScan = true;

                    counter = 0;
                }
                else
                {
                    if(!scanUI.enabled)
                    counter++;
                }


                if (canScan)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (tempClue == null || tempClue.transform != hit.transform)
                        {
                            // checkt of de clue t zelfde is, zo niet, dan pakt hij het object opnieuw op
                            tempClue = hit.transform.GetComponent<Clue>();
                        }
                    }
                    if (Input.GetMouseButton(0))
                    {
                            tempClue.Scanning();
                    }
                }
            }
            else
            {
                if(scanUI.enabled)
                    scanUI.enabled = false;
            }
        }
        else
        {
            if (scanUI.enabled)
                scanUI.enabled = false;
        }

    }


    
}
