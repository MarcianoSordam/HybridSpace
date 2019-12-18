using UnityEngine;

public class instantiateButton : MonoBehaviour
{
    public GameObject objecttest;
    private void Start()
    {
        Instantiate(objecttest);
    }
}
