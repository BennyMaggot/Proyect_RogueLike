using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    int NumEnemies1 = 10;
    int NumEnemies2 = 20;
    int NumEnemies3 = 30;

    public GameObject Enemy;
    public GameObject StopLightEnemy;
    public GameObject RunLightEnemy;
    public GameObject boss;
    public GameObject gameobject_slider;
    public bool ronda2 = true;
    public bool ronda3 = true;
    public bool rondaF = true;
    public cañon PlayerVida;
    public GameObject[] busqueda;
    public int Score = 0;

	void Start ()
    {
        Score = 0;
        StartCoroutine(Ronda1());//INICIA CON LA PRIMER RONDA
        StartCoroutine(EnableR1txt());//MUSTRA TEXTO RONDA 1

        
        //
    }
	
	void Update ()
    {
        GameObject text = GameObject.Find("ScoreText");
        Text txt = text.GetComponent<Text>();
        txt.text = "Score :" + Score;

        if (PlayerVida.vida <= 0)
        {
            /*GameObject text = GameObject.Find("GameOver");
            Text txt = text.GetComponent<Text>();
            txt.enabled = true;*/
            StartCoroutine(ButtonEffectOn());

            StartCoroutine(LoadMenu());
            GameObject jugador = GameObject.Find("Luz");
            jugador.SetActive(false);
        }

        //COMPARACIÓN PARA EJECUTAR LA SEGUNDA RONDA
        if (Score == 10 && ronda2 == true)
        { 
            StartCoroutine(Ronda2());
            StartCoroutine(EnableR2txt());
            StopCoroutine(Ronda1());
        }

        //COMPARACIÓN PARA EJECUTAR LA TERCER RONDA
        if (Score >= 30 && ronda3 == true)
        {
            StartCoroutine(Ronda3());
            StartCoroutine(EnableR3txt());
            StopCoroutine(Ronda2());
        }

        //COMPARACIÓN PARA EJECUTAR LA RONDA DEL FINAL BOSS
        if (Score >= 60 && rondaF == true)
        {
            StartCoroutine(RondaBossFinal());
            StartCoroutine(EnableRFtxt());
            busqueda = GameObject.FindGameObjectsWithTag("Enemy");
        }

        if (Score >= 160)
        {
            GameObject text2 = GameObject.Find("EpicWin");
            Text txt2 = text2.GetComponent<Text>();
            txt2.enabled = true;
            StartCoroutine(LoadMenu());
        }

    }

    IEnumerator ButtonEffectOff()
    {
        GameObject text = GameObject.Find("GameOver");
        Text txt = text.GetComponent<Text>();
        txt.enabled = false;
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ButtonEffectOn());
    }

    IEnumerator ButtonEffectOn()
    {
        GameObject text = GameObject.Find("GameOver");
        Text txt = text.GetComponent<Text>();
        txt.enabled = true;
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ButtonEffectOff());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }

    IEnumerator Ronda1()
    {
        for (int i = 0; i < NumEnemies1; i++)
        {
            Instantiate(Enemy);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Ronda2()
    {
        ronda2 = false;
        for (int i = 0; i < NumEnemies2; i++)
        {
            Instantiate(RunLightEnemy);
            Instantiate(Enemy);            
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Ronda3()
    {
        ronda3 = false;
        for (int i = 0; i < NumEnemies3; i++)
        {
            Instantiate(RunLightEnemy);
            Instantiate(Enemy);
            Instantiate(StopLightEnemy);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator RondaBossFinal()
    {
        rondaF = false;
        boss.SetActive(true);
        gameobject_slider.SetActive(true);
        yield return new WaitForSeconds(1f);
    }

    IEnumerator EnableR1txt()
    {
        //TEXTO COLOR
        GameObject R1txt = GameObject.Find("Ronda1");
        Text r1txt = R1txt.GetComponent<Text>();
        r1txt.enabled = true;

        //TEXTO SOMBRA
        GameObject R1txt1 = GameObject.Find("Text1");
        Text r1txt1 = R1txt1.GetComponent<Text>();
        r1txt1.enabled = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(DisableR1txt());
    }

    IEnumerator DisableR1txt()
    {
        //TEXTO COLOR
        GameObject R1txt = GameObject.Find("Ronda1");
        Text r1txt = R1txt.GetComponent<Text>();
        r1txt.enabled = false;

        //TEXTO SOMBRA
        GameObject R1txt1 = GameObject.Find("Text1");
        Text r1txt1 = R1txt1.GetComponent<Text>();
        r1txt1.enabled = false;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator EnableR2txt()
    {
        //TEXTO COLOR
        GameObject R2txt = GameObject.Find("Ronda2");
        Text r2txt = R2txt.GetComponent<Text>();
        r2txt.enabled = true;

        //TEXTO SOMBRA
        GameObject R2txt1 = GameObject.Find("Text2");
        Text r2txt1 = R2txt1.GetComponent<Text>();
        r2txt1.enabled = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(DisableR2txt());
    }

    IEnumerator DisableR2txt()
    {
        //TEXTO COLOR
        GameObject R2txt = GameObject.Find("Ronda2");
        Text r2txt = R2txt.GetComponent<Text>();
        r2txt.enabled = false;

        //TEXTO SOMBRA
        GameObject R2txt1 = GameObject.Find("Text2");
        Text r2txt1 = R2txt1.GetComponent<Text>();
        r2txt1.enabled = false;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator EnableR3txt()
    {
        //TEXTO COLOR
        GameObject R3txt = GameObject.Find("Ronda3");
        Text r3txt = R3txt.GetComponent<Text>();
        r3txt.enabled = true;

        //TEXTO SOMBRA
        GameObject R3txt1 = GameObject.Find("Text3");
        Text r3txt1 = R3txt1.GetComponent<Text>();
        r3txt1.enabled = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(DisableR3txt());
    }

    IEnumerator DisableR3txt()
    {
        //TEXTO COLOR
        GameObject R3txt = GameObject.Find("Ronda3");
        Text r3txt = R3txt.GetComponent<Text>();
        r3txt.enabled = false;

        //TEXTO SOMBRA
        GameObject R3txt1 = GameObject.Find("Text3");
        Text r3txt1 = R3txt1.GetComponent<Text>();
        r3txt1.enabled = false;
        yield return new WaitForSeconds(3f);
    }

    IEnumerator EnableRFtxt()
    {
        //TEXTO COLOR
        GameObject RFtxt = GameObject.Find("Ronda Final");
        Text rFtxt = RFtxt.GetComponent<Text>();
        rFtxt.enabled = true;

        //TEXTO SOMBRA
        GameObject RFtxt1 = GameObject.Find("Text4");
        Text rFtxt1 = RFtxt1.GetComponent<Text>();
        rFtxt1.enabled = true;
        yield return new WaitForSeconds(3f);
        StartCoroutine(DisableRFtxt());
    }

    IEnumerator DisableRFtxt()
    {
        //TEXTO COLOR
        GameObject RFtxt = GameObject.Find("Ronda Final");
        Text rFtxt = RFtxt.GetComponent<Text>();
        rFtxt.enabled = false;

        //TEXTO SOMBRA
        GameObject RFtxt1 = GameObject.Find("Text4");
        Text rFtxt1 = RFtxt1.GetComponent<Text>();
        rFtxt1.enabled = false;
        yield return new WaitForSeconds(3f);
    }

}
