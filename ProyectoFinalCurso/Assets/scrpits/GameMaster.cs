using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    // Use this for initialization
    public static GameMaster gm;
    public GameObject player;


	void Start () {
        if (gm== null)
        {
            gm= GameObject.FindGameObjectWithTag("_GM").GetComponent<GameMaster>();
        }
	}
    public Transform playerPrefab;
    public Transform spawnPoint;
    bool Revivir;
    bool ExisteCaballero;
    public int TiempoRespawn;
    void Update()
    {
        if (playerPrefab==null)
        {
            RespawnPlayer();
        }
    }
    public IEnumerator RespawnPlayer()
    {
        //Agregar sonido de spawn

        yield return new WaitForSeconds(TiempoRespawn);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        this.player.SetActive(true);
        //Agregar particulas de spawn
    }
	
	// Update is called once per frame
	public static void KillPlayer (Player player) {
        Destroy(player.gameObject);
       // gm.StartCoroutine(gm());
            
        
    }
}
