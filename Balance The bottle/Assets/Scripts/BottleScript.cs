using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottleScript : MonoBehaviour {

    public Transform spawnpoint;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }

        if(transform.position.y <= -5f)
        {
            //Restart
            SceneManager.LoadScene("Scene1");
        }

	}
}
