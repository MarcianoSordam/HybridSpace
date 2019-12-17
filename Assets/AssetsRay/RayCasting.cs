using UnityEngine;
using TMPro;

public class RayCasting : MonoBehaviour
{
    [SerializeField] OpenUI UIScript;
    [SerializeField] TextMeshProUGUI ObjectName;
    public Animator animator;
    bool screenup = false;

    private Clue tempClue;
    private void Start()
    {
        UIScript = GetComponent<OpenUI>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)) // mathf.infinity weghalen en vervangen door gewenste afstand/lengte
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //UIScript.OpenUp(hit.collider.gameObject.name);
            //animator.SetBool("Found", true);
            if(tempClue != null)
            {
                if(tempClue.transform != hit.transform)
                {
                    tempClue = hit.transform.GetComponent<Clue>();
                }

                tempClue.Scanning();
            }
            else
            {
                tempClue = hit.transform.GetComponent<Clue>();
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);

            ObjectName.text = "Scanning";
           // UIScript.OpenUp("None");
            animator.SetBool("Found", false);
            animator.SetBool("Info", false);
            screenup = false;

        }

    }


    public void moreInfo()
    {
        if (screenup == false)
        {
            screenup = true;
            animator.SetBool("Info", true);

        }
        else if (screenup == true)
        {
            screenup = false;
            animator.SetBool("Info", false);

        }

    }
}
