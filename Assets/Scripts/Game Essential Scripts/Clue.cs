using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public string title;
    public string description;
    
    private ClueManager mainClueManager;

    private void Awake()
    {
        mainClueManager = FindObjectOfType<ClueManager>();
    }
    public void Scanning()
    {
        mainClueManager.LoadClue(title, description);
    }
}
