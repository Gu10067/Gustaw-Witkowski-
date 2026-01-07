using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    public GameObject restartText; 

    public GameObject gameEnd;

    
    public GameObject playerWin;
    public GameObject computerWin;

    public int winScore = 5;

    private int _playerScore = 0;
    private int _computerScore = 0;
    private bool gameOver = false;

    public void PlayerScores()
    {
        if (gameOver) return;

        _playerScore++;
        playerScoreText.text = _playerScore.ToString();

        if (_playerScore >= winScore)
        {
            PlayerWins();
        }
        else
        {
            ResetRound();
        }
    }

    public void ComputerScores()
    {
        if (gameOver) return;

        _computerScore++;
        computerScoreText.text = _computerScore.ToString();

        if (_computerScore >= winScore)
        {
            ComputerWins();
        }
        else
        {
            ResetRound();
        }
    }

    private void PlayerWins()
    {
        gameOver = true;

        gameEnd.SetActive(true);
        playerWin.SetActive(true);
        computerWin.SetActive(false);
        restartText.SetActive(true); 


        Time.timeScale = 0f;
    }

    private void ComputerWins()
    {
        gameOver = true;

        gameEnd.SetActive(true);
        computerWin.SetActive(true);
        playerWin.SetActive(false);
        restartText.SetActive(true); 


        Time.timeScale = 0f;
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }


    public bool IsGameOver()
    {
        return gameOver;
    }

    
    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Return))
        {
            RestartGame();
        }
    }

    
    private void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}