using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
