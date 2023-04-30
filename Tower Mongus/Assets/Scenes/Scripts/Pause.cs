using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    
    private bool isPaused = false;

    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            
            isPaused = false;
        }
    }
}

