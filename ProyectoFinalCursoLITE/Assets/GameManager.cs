using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    bool TerminoJuego=false;
    public GameObject CompleteLevelUI;
     FondoInfinito fondo;
    public void EndGame()
    
    {
        if (TerminoJuego==false)
        {


            TerminoJuego = true;
            Debug.Log("GAMe Over");
            restart();
        }
        
    }
    public void restart()
    {
        ScoreScript.ScoreValue =ScoreScript.TotalScore;
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        
    }
    public void PasarNivel()
    {
        ScoreScript.TotalScore = ScoreScript.ScoreValue;
        CompleteLevelUI.SetActive(true);
        Debug.Log("Pasaste de nivel");
        Invoke("CargarNivelSig", 3f);
        FindObjectOfType<FondoInfinito>().scrollSpeed += 100;



    }
    public void CargarNivelSig()
    {
            CompleteLevelUI.SetActive(false);    
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    
    
    }


}
