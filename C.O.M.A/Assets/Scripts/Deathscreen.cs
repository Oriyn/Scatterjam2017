using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	   if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Application.LoadLevel(0);
        }
       if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel(0);
        }
	}
}
