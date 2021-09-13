using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour {
    public Vector3 RespawnPoint, RespawnCamara;
    public PlayerMovement Player;
    public GameObject playerGameObject;
    public GameObject FireGameObject;

    public FondoInfinito MovimientoFondo;
     
    public Transform Camara;
    [SerializeField] private Animator MyAnimationController;
    public GameObject Explosion;
    public float TiempoRespawn;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            SoundManagerScript.PlaySound(collision.gameObject.tag);

            Debug.Log("Tocaste una moneda");
            Destroy(collision.gameObject);
            ScoreScript.ScoreValue += 1;
        }
        else if (collision.gameObject.tag == "Obstaculo")
        {
            MovimientoFondo.enabled = false;
            Player.enabled = false;
            playerGameObject.GetComponent<SpriteRenderer>().enabled = false;
            FireGameObject.GetComponent<SpriteRenderer>().enabled = false;
            playerGameObject.GetComponent<PolygonCollider2D>().enabled = false;
            SoundManagerScript.PlaySound(collision.gameObject.tag);
            Explosion.SetActive(true);
            MyAnimationController.SetBool("Explosion", true);
            Invoke("LLamarAnim", 1f);


            // FindObjectOfType<GameManager>().EndGame();
        }
    }
   /* private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Obstaculo")
        {

            Invoke("LLamarAnim", 0.4f);


        }
        //  playerGameObject.GetComponent<SpriteRenderer>().enabled = true;


    }*/
   public void LLamarAnim()
    {

        Explosion.SetActive(false);
        MyAnimationController.SetBool("Explosion", false);
        FindObjectOfType<GameManager>().EndGame();
    }

   /* public void DieAndRespawn()
    {

        //MovimientoFondo.enabled = false;
        
        Camara.position = RespawnCamara;
        transform.position = RespawnPoint;
        transform.rotation = Quaternion.identity;
        Player.enabled = true;
        MovimientoFondo.enabled = true;
        Camara.gameObject.SetActive(true);
        this.gameObject.SetActive(true);
    }*/
}
