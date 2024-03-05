using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("sample");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}