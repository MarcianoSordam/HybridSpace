using UnityEngine;

public class SpawnObjectScript : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] AudioSource geluid;
    // Start is called before the first frame update
    void start()
    {
        Instantiate(spawnObject);
        geluid.Play();
    }

}
