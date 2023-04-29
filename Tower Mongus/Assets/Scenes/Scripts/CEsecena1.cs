using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CEsecena1 : MonoBehaviour
{
    
    public void CambiarAEscena(string Game)
    {
        SceneManager.LoadScene(Game);
    }
}
