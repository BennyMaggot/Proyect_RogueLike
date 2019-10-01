using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCreditos : MonoBehaviour
{
    public GameObject MenuPrincipal;
    public GameObject Creditos;
    public Animator Anim;
    private void OnMouseDown()
    {
        StartCoroutine("AnimacionClic");
    }

    IEnumerator AnimacionClic()
    {
        Anim.Play("CreditosBoton");
        yield return new WaitForSeconds(0.3f);
        MenuPrincipal.SetActive(false);
        Creditos.SetActive(true);
    }
}
