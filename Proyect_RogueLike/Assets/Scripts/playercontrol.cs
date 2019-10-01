using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrol : MonoBehaviour {

    Vector3 mousepos;
    Vector3 direccion;
    Camera cam;
    Rigidbody rigid; 
    public float horizontalSpeed = 8.0F;
    public float verticalSpeed = 8.0F;

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


        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        float rotation = (v + h) * 10;

        transform.Rotate(0, rotation, 0);
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);//desde la posicion de la camara saca una direccion
        var angulo = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg + 50;//saca el angulo entre la camara y el player
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.up);//hace que rote el player en base a el angulo que hay entre el mouse y el player
    }


}
