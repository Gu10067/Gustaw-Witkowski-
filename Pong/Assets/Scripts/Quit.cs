using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Close()
    {   
        #if Unity_Editor
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}