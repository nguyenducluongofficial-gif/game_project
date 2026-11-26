
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text winText;
    public TMP_Text livesText;

    [Header("Game Settings")]
    public int targetScore = 5;
    public int startingLives = 3;

    private int score = 0;
    private int lives;

    public bool HasEnoughCoins
    {
        get { return score >= targetScore; }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1f;

        lives = startingLives;

        UpdateScore();
        UpdateLives();

        if (winText != null)
        {
            winText.enabled = true;
            winText.gameObject.SetActive(false);
        }
    }

    public void AddScore()
    {
        score++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "SCORE: " + score + " / " + targetScore;
        }
    }

    private void UpdateLives()
    {
        if (livesText != null)
        {
            livesText.text = "LIVES: " + lives;
        }
    }

    public void TakeDamage()
    {
        if (lives <= 0)
        {
            return;
        }

        lives--;

        if (lives < 0)
        {
            lives = 0;
        }

        UpdateLives();

        Debug.Log("Player bị trừ 1 mạng! Số mạng còn lại: " + lives);

        if (lives == 0)
        {
            Debug.Log("GAME OVER!");

            Time.timeScale = 0f;
        }
    }

    public void WinGame()
    {
        if (!HasEnoughCoins || lives <= 0)
        {
            return;
        }

        if (winText != null)
        {
            winText.enabled = true;
            winText.gameObject.SetActive(true);
        }

        Time.timeScale = 0f;
    }
}
