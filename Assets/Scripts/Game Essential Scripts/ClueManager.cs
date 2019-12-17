using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueManager : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void LoadClue(string _title, string _description)
    {
        anim.SetBool("Found", true);
        title.text = _title;
        description.text = _description;
    }

    public void DisableClue()
    {
        anim.SetBool("Found", false);
    }

}
