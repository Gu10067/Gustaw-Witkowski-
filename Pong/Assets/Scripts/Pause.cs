using UnityEngine;

public class PauseManager : MonoBehaviour
{   
    public GameManager gameManager;
    public GameObject pause;
    private bool isPaused = false;

    void Start()
    {
        pause.SetActive(false);   
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {   

        if (gameManager.IsGameOver())
            return;

        isPaused = !isPaused;

        pause.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }
}
