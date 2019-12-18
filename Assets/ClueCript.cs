using UnityEngine;

public class ClueCript : MonoBehaviour
{
    OpenUI ui;
    [SerializeField] string Title;
    [SerializeField] string text;
    [SerializeField] StateManager stateManager;
    bool scanned = false;
    private void Start()
    {
        ui = GameObject.Find("AR Camera").GetComponent<OpenUI>();
        stateManager = GameObject.Find("GameManager").GetComponent<StateManager>();
    }

    void SendInfo()
    {
        ui.OpenUp(Title, text);
        if ( scanned == false)
        {
            stateManager.CountClue();
            scanned = true;
        }
    }




}
