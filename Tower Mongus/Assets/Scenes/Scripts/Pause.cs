using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    

    public void Start()
    {
        Time.timeScale = 1;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }
    public void Resetion()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menudo(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);

    }

    public void ExitMainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLvl2()
    {
        SceneManager.LoadScene("Lvl2");
    }
    
    public void LoadLvl3()
    {
        SceneManager.LoadScene("Lvl3");
    }
}

