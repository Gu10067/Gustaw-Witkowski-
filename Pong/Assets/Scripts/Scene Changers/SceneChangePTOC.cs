using UnityEngine;
using UnityEngine.SceneManagement;

public class  SceneChangePTOC : MonoBehaviour
{
    public string Pongpve;

    public void SceneChange()
    {   
        SceneManager.LoadScene(Pongpve);
    }
}