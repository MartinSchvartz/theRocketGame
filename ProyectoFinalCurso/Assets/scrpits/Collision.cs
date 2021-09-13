    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    
    private GameMaster gm;
   
    public Player Player;
    public float tiempoRespawn;
    public Transform transform;
    public Vector3 RespawnPoint;
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
            DieAndRespawn();
        }

        //gm = GameObject.FindGameObjectWithTag("_GM").GetComponent<GameMaster>();
        Debug.Log("Tocaste algo");
        //var A= collision.fi
        //GameMaster.KillPlayer(Player);
      
        //this.gameObject.SetActive(false);
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
