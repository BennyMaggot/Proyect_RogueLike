using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cañon : MonoBehaviour {

    public float vida = 1f;
    public Slider slider_vida;
    public GameObject player;
    public GameObject invencible;
    //cree este script para ponerselo a un cañoncito en frente de el player y que ese sea el que dispare

    public GameObject bala; //PARA INSTANCIAR LA BALA

   
    void Start ()
    {
		
	}
	

	void Update () {
        Disparo();
        slider_vida.value = vida;

        if (vida <= 0)
        {
            /*GameObject text = GameObject.Find("GameOver");
            Text txt = text.GetComponent<Text>();
            txt.enabled = true;*/
            //StartCoroutine(LoadMenu());
            Destroy(player);
            /*GameObject jugador = GameObject.Find("Luz");
            jugador.SetActive(false);*/
        }
    }

    void Disparo()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("DISPARANDO BALA");
            Instantiate(bala, gameObject.transform.position, gameObject.transform.rotation);//instancia la bala hacia donde está el mouse xd
            AudioSource sonidobala = gameObject.GetComponent<AudioSource>();
            sonidobala.Play();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            vida = vida - 0.20f;
        }
        if (other.tag.Equals("escudito"))
        {
            vida = 0;
            Destroy(gameObject);
        }
        if (other.tag.Equals("power_up"))
        {
            invencible.SetActive(true);
        }
    }

    /*IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }*/
}
