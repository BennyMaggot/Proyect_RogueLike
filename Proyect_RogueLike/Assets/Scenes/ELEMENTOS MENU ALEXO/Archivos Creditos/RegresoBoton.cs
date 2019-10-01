using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegresoBoton : MonoBehaviour
{
    public GameObject MenuPrincipa;
    public GameObject Creditos;
    public Animator anim;
    private void OnMouseDown()
    {
        StartCoroutine("AnimacionClic");
    }

    IEnumerator AnimacionClic()
    {
        anim.Play("RegresoBoton");
        yield return new WaitForSeconds(0.3f);
        MenuPrincipa.SetActive(true);
        Creditos.SetActive(false);
    }
}
