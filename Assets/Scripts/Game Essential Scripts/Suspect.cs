using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Suspect", menuName = "Create Suspect")]
public class Suspect : ScriptableObject
{
    public string naam;
    public Image foto;
    public int leeftijd;
    public float lengte;
    public string beroep;
    public Strafblad strafblad;
}

public enum Strafblad
{
    Ja,
    Nee
}
