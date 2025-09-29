using UnityEngine;

public class ClassInfo : MonoBehaviour
{
    public string className;
    public int value;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int getValue()
    {
        return this.value;
    }
}
