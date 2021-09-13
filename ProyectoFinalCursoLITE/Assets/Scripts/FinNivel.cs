
using UnityEngine;

public class FinNivel : MonoBehaviour {
    public GameManager gameManager;
    public void OnTriggerEnter2D()
    {
        Debug.Log("pasaste");
       gameManager.PasarNivel();
    }
}
