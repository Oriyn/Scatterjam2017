using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag.Equals("Monster") == true)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
