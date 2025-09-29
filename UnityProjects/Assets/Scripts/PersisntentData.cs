// En un script llamado PersistentData.cs
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    public static PersistentData Instance { get; private set; } // Instancia única del Singleton
    public bool GameOver; // El valor que quieres pasar

    void Update()
    {
        GameOver = GameObject.FindWithTag("Player").GetComponent<PlayerController>().isGameOver;
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // <<!nav>>Mantener el objeto entre escenas<<!/nav>>
        }
        else
        {
            Destroy(gameObject); // Destruye las instancias duplicadas
        }
    }
}