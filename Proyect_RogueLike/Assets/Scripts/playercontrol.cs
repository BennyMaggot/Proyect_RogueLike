using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrol : MonoBehaviour {

    Vector3 mousepos;
    Vector3 direccion;
    Camera cam;
    Rigidbody rigid;
    void Start ()
    {
        rigid = this.GetComponent<Rigidbody>();
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
      mirar_al_mouse();

	}

    void mirar_al_mouse()
    {

        mousepos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - cam.transform.position.x, Input.mousePosition.y, Input.mousePosition.z));

        rigid.transform.eulerAngles = new Vector3(0, Mathf.Atan2((mousepos.y - transform.position.y), (mousepos.x - transform.position.x)) * Mathf.Rad2Deg, 0);
        //var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);//desde la posicion de la camara saca una direccion
        //var angulo = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;//saca el angulo entre la camara y el player
        //transform.rotation = Quaternion.AngleAxis(angulo,Vector3.down);//hace que rote el player en base a el angulo que hay entre el mouse y el player
    }


}
