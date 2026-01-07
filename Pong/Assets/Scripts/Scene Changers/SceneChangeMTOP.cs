using UnityEngine;
using UnityEngine.SceneManagement;

public class  SceneChangeMTOP : MonoBehaviour
{
    public string Play;

    public void SceneChange()
    {
        SceneManager.LoadScene(Play);
    }
}