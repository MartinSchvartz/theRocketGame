    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    
   
    public PlayerMovement Player;
    public Transform transform;
    public Vector2 RespawnPoint;
    public float TiempoRespawn;
    [SerializeField] private Animator myAnimationController;
    private void Update()
    {
        if (transform.position.y<-10)
        {
            DieAndRespawn();

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)// collision es con la cosa que choca
    {
        if (collision.tag=="Obstaculo")
        {
            myAnimationController.enabled = true;
            myAnimationController.SetBool("Explosion", true);


            ExecuteAfterTime(TiempoRespawn);

        }
        Player.enabled = false;
        Debug.Log("Tocaste algo");

        //gm = GameObject.FindGameObjectWithTag("_GM").GetComponent<GameMaster>();
        //var A= collision.fi
        //GameMaster.KillPlayer(Player);

        //this.gameObject.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Obstaculo")
        {
            myAnimationController.SetBool("Explosion", false);

            myAnimationController.enabled = false;


        }
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        DieAndRespawn();
    }
    public void DieAndRespawn()
        {
            Player.enabled = false;
            this.gameObject.SetActive(false);
            transform.position =RespawnPoint;
            transform.rotation = Quaternion.identity;
            Player.enabled = true;
            this.gameObject.SetActive(true);
        }
}
