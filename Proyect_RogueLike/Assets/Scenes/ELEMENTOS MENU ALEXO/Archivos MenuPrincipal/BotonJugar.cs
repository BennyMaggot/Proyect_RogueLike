using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public Animator Anim;
    private void OnMouseDown()
    {
        StartCoroutine("AnimacionClic");
    }

    IEnumerator AnimacionClic()
    {
        Anim.Play("JugarAnim");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Game");
    }
}
