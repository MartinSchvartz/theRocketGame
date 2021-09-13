using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {
    public GameObject CompleteLevelUI;
    public void CargarProxLevel()
    {
        Debug.Log("Cambiamos la escena");
      //  CompleteLevelUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
