using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrol : MonoBehaviour {



    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      mirar_al_mouse();

	}

    void mirar_al_mouse()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);//desde la posicion de la camara saca una direccion
        var angulo = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;//saca el angulo entre la camara y el player
        transform.rotation = Quaternion.AngleAxis(angulo,Vector3.down);//hace que rote el player en base a el angulo que hay entre el mouse y el player
    }


}
