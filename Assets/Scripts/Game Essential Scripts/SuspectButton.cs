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
    private Image afbeelding;
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

    private void Start()
    {
        button = GetComponent<Button>();
        chooseSuspect = FindObjectOfType<ChooseSuspect>();

        naam.text = "Name: " + thisSuspect.naam;
        afbeelding = thisSuspect.foto;
        leeftijd.text = "Age: " + thisSuspect.leeftijd.ToString(); ;
        lengte.text = "Length: " + thisSuspect.lengte.ToString(); ;
        beroep.text = "Occupation: " + thisSuspect.beroep;
        strafblad.text = "Criminal record: " + thisSuspect.strafblad.ToString();

        button.onClick.AddListener(ChooseThisSuspect);

    }

    public void ChooseThisSuspect()
    {
        chooseSuspect.CheckSuspect(thisSuspect);
    }
}
