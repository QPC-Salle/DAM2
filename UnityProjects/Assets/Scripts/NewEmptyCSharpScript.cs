using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Button clicked!");
        LoadScene("Game");
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
