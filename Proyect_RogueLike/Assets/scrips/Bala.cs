using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    Coroutine Destruyendo;//VARIABLE QUE HACE REFERENCIA A UNA CORRUTINA
                         
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        AutoDestruccion();
    }

    void OnTriggerEnter(Collider col)//SI CHOCA CON EL ENEMIGO SE DESTRUYE LA BALA
    {
        if (col.tag.Equals("Enemy"))
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

    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        Destruyendo = null;
    }
}
