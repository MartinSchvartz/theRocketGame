using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalScreen : MonoBehaviour {

    public void VolverAlMenu()
    {
        ScoreScript.ScoreValue = 0;
        ScoreScript.TotalScore = 0;
        SceneManager.LoadScene("MENU", LoadSceneMode.Single);
        
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Cerraste el juego");
    }
}
