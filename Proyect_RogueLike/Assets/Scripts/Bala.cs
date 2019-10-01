using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour {

    Coroutine Destruyendo;//VARIABLE QUE HACE REFERENCIA A UNA CORRUTINA
    GameController GameController;
    public int speed;
                         
    void Start () {
        //GameController = GetComponent<GameController>();
        StartCoroutine("destrucsion");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        AutoDestruccion();
    }

    void OnTriggerEnter(Collider col)//SI CHOCA CON EL ENEMIGO SE DESTRUYE LA BALA
    {
        if (col.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
            GameObject.Find("GameController").GetComponent<GameController>().Score++;
            Debug.Log("SCORE ACTUAL: " + GameObject.Find("GameController").GetComponent<GameController>().Score);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name =="escudito")
        {
            Destroy(gameObject);
        }
    }

    void AutoDestruccion()//TIEMPO PARA QUE SE DESTRUYA LA BALA SI NO COLISIONA CON NADA
    {
        if (Destruyendo == null)
        {
            Destruyendo = StartCoroutine("Destruir");
        }
    }
    IEnumerator destrucsion()//TIEMPO PARA QUE SE DESTRUYA LA BALA SI NO COLISIONA CON NADA
    {

        //Destruyendo = StartCoroutine("Destruir");
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }


    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        Destruyendo = null;
    }
}
