using UnityEngine;
using UnityEngine.SceneManagement;

public class PvEscape : MonoBehaviour
{
    [SerializeField] private string Play;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(Play);
        }
    }
    
}