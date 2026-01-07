using UnityEngine;
using UnityEngine.SceneManagement;

public class  SceneChangePTOP : MonoBehaviour
{
    public string Pongpvp;

    public void SceneChange()
    {   
        Debug.Log("Button clicked");
        SceneManager.LoadScene(Pongpvp);
    }
}