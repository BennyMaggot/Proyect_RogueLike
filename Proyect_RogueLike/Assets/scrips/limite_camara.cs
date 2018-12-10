using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limite_camara : MonoBehaviour {

    //este script sirve para seguir al jugador y ademas delimitarle a la camara 

    private Vector2 velocity;

    public float smothtimey;//propiedad para que funcione el seguimiento de la camara
    public float smothtimex;//propiedad para que funcione el seguimiento de la camara

    public GameObject player;//el objeto que la camara seguira
    public bool bounds;//para activar que la camara deje de seguir al jugador tras cierto punto

    public Vector3 mincamarapos,maxcamarapos;//para darle una distancia maxima y minima de hasta donde recorre el seguimiento de la camara
    





    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        limite();
	}
    void limite()
    {
        float posx = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x,smothtimex);
        float posy = Mathf.SmoothDamp(transform.position.y+13, player.transform.position.y+13, ref velocity.y, smothtimey);//aqui se dan las posiciones iniciales de la camara
        float posz = Mathf.SmoothDamp(transform.position.z, player.transform.position.z, ref velocity.x, smothtimey);
        transform.position = new Vector3(posx,posy,posz);

        if(bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, mincamarapos.x, maxcamarapos.x),
                                            Mathf.Clamp(transform.position.y+5, mincamarapos.y+5, maxcamarapos.y+5),//aqui se dan las posiciones iniciales de la camara si se activa el "bounds"
                                            Mathf.Clamp(transform.position.z, mincamarapos.z, maxcamarapos.z));
        }
    }
}
