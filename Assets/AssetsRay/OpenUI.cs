using UnityEngine;
using System.Collections;
using TMPro;

public class OpenUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moreInfoText;
    [SerializeField] TextMeshProUGUI objectName;
    [SerializeField] Animator animator;
    bool screenup = false;


    public void OpenUp(string Title, string Text)
    {
        if (screenup == false)
        {
            animator.SetBool("Found", true);
            objectName.text = Title;            
            moreInfoText.text = Text;
            
        }
    }

    public void CloseDown()
    {
        if (screenup == false)
        {
            StartCoroutine(CloseDelay());
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
            animator.SetBool("Found", false);
            objectName.text = "Scanning";

        }

    }

    IEnumerator CloseDelay()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Found", false);
        objectName.text = "Scanning";
    }


}
