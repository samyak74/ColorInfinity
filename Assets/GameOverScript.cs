using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
       
            Debug.Log("Game Over");
        //Handheld.Vibrate();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
}
