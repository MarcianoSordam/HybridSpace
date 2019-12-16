using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SuspectButton : MonoBehaviour
{
    public Suspect thisSuspect;
    [SerializeField]
    private TextMeshProUGUI naam;
    [SerializeField]
    private TextMeshProUGUI leeftijd;
    [SerializeField]
    private TextMeshProUGUI lengte;
    [SerializeField]
    private TextMeshProUGUI beroep;
    [SerializeField]
    private TextMeshProUGUI strafblad;
    [SerializeField]
    private Button button;
    [SerializeField]
    private ChooseSuspect chooseSuspect;

    private void Awake()
    {
        button = GetComponent<Button>();
        chooseSuspect = FindObjectOfType<ChooseSuspect>();
    }

    public void ChooseThisSuspect()
    {

    }
}
