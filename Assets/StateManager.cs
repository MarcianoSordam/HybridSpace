using UnityEngine;
using System.Collections;
using TMPro;

public class StateManager : MonoBehaviour
{
    GameObject RoomSpawner;
    public TextMeshProUGUI debugtext;
    public PlaceMultipleObjectsOnPlane PlaceStuff;
    GameObject Orienter;
    [SerializeField] GameObject InfoUI;
    [SerializeField] GameObject CalibratingScreen;
    [SerializeField] GameObject LookAroundUI;
    [SerializeField] GameObject InvestigationRoom;
    GameObject RotateThis;
    [SerializeField] ParticleSystem ptsystem1, ptsystem2;
    [SerializeField] int MinimalCluesNeed = 10;
    private int clueCount;


    private void Start()
    {
        // Disable screen dimming
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void SwitchState(string state)
    {
        switch (state)
        {
            case "PlacingRoom":
                //disable stuff

                //enable stuff
                LookAroundUI.SetActive(true);
                PlaceStuff.enabled = true;//enables room placement
                break;

            case "Calibrating":
                PlaceStuff.enabled = false;//disables room placement
                CalibratingScreen.SetActive(true);
                LookAroundUI.SetActive(false);
                break;

            case "Investigating":
                CalibratingScreen.SetActive(false);
                InfoUI.SetActive(true);

                //look for RoomSpawner and Orienter
                RoomSpawner = GameObject.Find("RoomSpawner");
                Orienter = GameObject.Find("RoomOrienter");

                //instantiate room
                Instantiate(InvestigationRoom, RoomSpawner.transform);

                //find spawned room
                RotateThis = GameObject.Find("RoomEmpty(Clone)");

                //turn spawned room towards the orienter
                RotateThis.transform.LookAt(Orienter.transform);
                ptsystem1 = GameObject.Find("RoomOrienter").GetComponent<ParticleSystem>();
                ptsystem2 = GameObject.Find("RoomSpawner").GetComponent<ParticleSystem>();
                ptsystem1.Stop();
                ptsystem2.Stop();

                break;
        }
    }

    public void DebugMessage(string message)
    {
        debugtext.text = message;
    }

    public void CountClue()
    {
        clueCount += 1;
        if (clueCount >= MinimalCluesNeed)
        {
            //prompt screen with guessing to open
        }
    }

}
