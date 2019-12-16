using System.Collections;
using UnityEngine;
using TMPro;

public class OpenUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moreInfoText;
    [SerializeField] TextMeshProUGUI objectName;
    [SerializeField] string text1;
    [SerializeField] string text2;

    public void OpenUp(string Target)
    {
        switch (Target)
        {
            case "Target1":
                moreInfoText.text = text1;
                objectName.text = "Target1";
                break;
            case "Target2":
                moreInfoText.text = text2;
                objectName.text = "Target2";
                break;
        }
    }
}
