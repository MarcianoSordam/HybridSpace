using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSuspect : MonoBehaviour
{
    public List<Suspect> allSuspects = new List<Suspect>();
    [SerializeField]
    private Suspect theSuspect;
    [SerializeField]
    private GameObject uiButton;
    private void OnEnable()
    {
        foreach(Suspect suspect in allSuspects)
        {
            GameObject _temp = Instantiate(uiButton, transform.position, Quaternion.identity);
            _temp.transform.SetParent(this.transform);
            SuspectButton _tempBut = _temp.GetComponent<SuspectButton>();
            _tempBut.thisSuspect = suspect;
        }
    }

    public void CheckSuspect(Suspect _suspect)
    {
        if(_suspect == theSuspect)
        {
            // hier is de juiste
<<<<<<< HEAD
            Debug.Log("TRUE");
=======
            Debug.Log("Correct Suspect");
>>>>>>> 188b82a7c18ebe8b5284dffdcb1e8d700b4098ac
        }
        else
        {
            // hier is de onjuiste
<<<<<<< HEAD
            Debug.LogError("False");
=======
            Debug.LogError("Wrong Suspect");
>>>>>>> 188b82a7c18ebe8b5284dffdcb1e8d700b4098ac
        }
    }

}
