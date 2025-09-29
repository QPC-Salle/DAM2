using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void NewGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitButton()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
