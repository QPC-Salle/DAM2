using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int rngDirection;
    public int rotationSpeed;
    void Start()
    {
        rngDirection = Random.Range(0, 2) * 2 - 1; // Randomly get either -1 or 1
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45 * rngDirection) * Time.deltaTime * rotationSpeed);
    }
}
