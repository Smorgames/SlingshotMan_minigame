using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    private TextMeshProUGUI _score;

    private void Awake()
    {
        _score = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        if (GameManager.instance.GetScore() >= PlayerPrefs.GetInt("BestScore", 0))
        {
            _score.text = GameManager.instance.GetScore().ToString();
            PlayerPrefs.SetInt("BestScore", GameManager.instance.GetScore());
        }
        else
            _score.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }
}
