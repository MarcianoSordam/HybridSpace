using System.Collections;
using UnityEngine;

public class LookTowards : MonoBehaviour
{
    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;
    [SerializeField] Transform TargetNone;
    Transform Target;
    int count = 0;

    void Start()
    {
        Target = TargetNone;
    }

    void Update()
    {
        transform.LookAt(Target);
        if (Input.GetKeyDown("m"))
        {
            SwitchTarget();
        }

    }

    void SwitchTarget()
    {
        count += 1;

        switch (count)
        {
            case 0:
                Target = TargetNone;
                break;
            case 1:
                Target = Target1;
                break;
            case 2:
                Target = Target2;
                break;
            case 3:
                count = 0;
                Target = TargetNone;
                break;
        }
    }

}
