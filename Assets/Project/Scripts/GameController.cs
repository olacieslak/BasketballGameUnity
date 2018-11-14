using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //refernece to player
    public Player player;

    public float resetTimer = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(player.holdingBall == false)
        {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0)
            {
                //przeladowanie sceny -> powrot do sceny glownej
                //"Game" - nazwa sceny
                SceneManager.LoadScene("Game");
            }
        }
	}
}
