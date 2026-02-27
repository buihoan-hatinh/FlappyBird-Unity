using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 Instance;

    public GameObject gameOverText;
    public GameObject restartButton;

    public TextMeshProUGUI scoreText;

    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
        score = 0;

        if (scoreText != null)
            scoreText.text = "0";
    }

    public void AddScore()
    {
        score++;

        if (scoreText != null)
            scoreText.text = score.ToString();

        Debug.Log("Score: " + score);
    }

    public void ShowGameOver()
    {
        Time.timeScale = 0;

        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        Debug.Log("SHOW GAME OVER");
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}