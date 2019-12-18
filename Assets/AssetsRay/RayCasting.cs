using UnityEngine;
using TMPro;

public class RayCasting : MonoBehaviour
{
    [SerializeField] OpenUI UIScript;
    //[SerializeField] TextMeshProUGUI ObjectName;
    //public Animator animator;
    //bool screenup = false;
    [SerializeField] float range;

    private void Start()
    {
        UIScript = GetComponent<OpenUI>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if(hit.collider.gameObject.tag == "clue")
            {
                hit.collider.gameObject.SendMessage("SendInfo");
            }
            else
            {
                UIScript.CloseDown();
            }

            //animator.SetBool("Found", true);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            UIScript.CloseDown();

            //ObjectName.text = "Scanning";
            //animator.SetBool("Found", false);
            //animator.SetBool("Info", false);

        }

    }

    /*
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
    */
}
