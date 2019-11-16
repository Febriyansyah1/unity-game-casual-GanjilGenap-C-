using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hilang : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
       // SceneManager.LoadScene("GameOver"); 
    }
}
