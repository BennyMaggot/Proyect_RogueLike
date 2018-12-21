using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        mover_al_jugador();

    }
    void mover_al_jugador()//no tiene ciencia, solo mueve al player depende de que tecla del wasd presione
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.2f);
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -0.2f);
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-0.2f, 0, 0);
                }
                else
                {
                    if (Input.GetKey(KeyCode.D))
                    {
                        transform.Translate(0.2f, 0, 0);
                    }
                }
            }
        }
    }
}
