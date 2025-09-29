using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public Text gameOverText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Set(PersistentData.Instance.GameOver);
    }

    void Set(bool isGameOver)
    {
        if (isGameOver)
        {
            gameOverText.text = "Game Over";
        }
        else
        {
            gameOverText.text = "You Win!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
