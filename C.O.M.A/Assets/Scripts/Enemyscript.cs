using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour {

    public Rigidbody2D enemy;
    public float enemySpeed;
    public Object player;

    void Start ()
    {  
        enemy = GetComponent<Rigidbody2D>();
	}
	
	
	void Update ()
    {
        enemy.velocity = new Vector3(enemySpeed,0,0);
        gameObject.tag = "Monster";
	}

    
}