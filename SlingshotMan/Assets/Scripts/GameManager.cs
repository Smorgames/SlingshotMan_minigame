using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        SetScore();
    }

    public TextMeshProUGUI ScoreText;

    [SerializeField] private GameObject _gameOverPanel;
    private int _score;

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlusScore(int amount)
    {
        _score += amount;
        ScoreText.text = _score.ToString();
    }

    public int GetScore()
    {
        return _score;
    }

    private void SetScore()
    {
        _score = 0;
        ScoreText.text = _score.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            GameOver();
    }
}
