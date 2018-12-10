using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)//SI CHOCA CON LA BALA SE DESTRUYE EL ENEMIGO
    {
        if (col.tag.Equals("Bala"))
        {
            Destroy(gameObject);
        }
    }
}
