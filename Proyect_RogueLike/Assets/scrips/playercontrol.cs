using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour {

    public GameObject bala; //PARA INSTANCIAR LA BALA

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      mirar_al_mouse();
      Disparo();
	}

    void mirar_al_mouse()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angulo = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo,Vector3.down);
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
