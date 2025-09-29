using UnityEngine;

public class Avoider : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }
    }
}
