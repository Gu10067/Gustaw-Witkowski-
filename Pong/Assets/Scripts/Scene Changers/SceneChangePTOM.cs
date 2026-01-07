using UnityEngine;
using UnityEngine.SceneManagement;

public class  SceneChangePTOM : MonoBehaviour
{
    public string Menu;

    public void SceneChange()
    {   
        SceneManager.LoadScene(Menu);
    }
}