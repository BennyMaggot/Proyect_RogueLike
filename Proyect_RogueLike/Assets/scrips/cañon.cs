using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour {

    //cree este script para ponerselo a un cañoncito en frente de el player y que ese sea el que dispare

    public GameObject bala; //PARA INSTANCIAR LA BALA

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        Disparo();
    }

    void Disparo()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("DISPARANDO BALA");
            Instantiate(bala, gameObject.transform.position, gameObject.transform.rotation);//instancia la bala hacia donde está el mouse xd
        }
    }
}
