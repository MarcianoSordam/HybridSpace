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
            SuspectButton _tempBut = _temp.GetComponent<SuspectButton>();
            _tempBut.
        }
    }
}
