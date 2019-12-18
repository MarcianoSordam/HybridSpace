using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueManager : MonoBehaviour
{
<<<<<<< HEAD
    private GameObject clueScreen;
=======
>>>>>>> 188b82a7c18ebe8b5284dffdcb1e8d700b4098ac
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
<<<<<<< HEAD
        clueScreen.SetActive(false);
=======
>>>>>>> 188b82a7c18ebe8b5284dffdcb1e8d700b4098ac
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
