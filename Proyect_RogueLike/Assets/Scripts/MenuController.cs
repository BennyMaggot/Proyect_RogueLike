using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(ButtonEffectOff1());
        StartCoroutine(ButtonEffectOff2());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ButtonEffectOff1()
    {
        GameObject button = GameObject.Find("Play");
        Image image = button.GetComponent<Image>();
        image.enabled = false;
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ButtonEffectOn1());
    }

    IEnumerator ButtonEffectOn1()
    {
        GameObject button = GameObject.Find("Play");
        Image image = button.GetComponent<Image>();
        image.enabled = true;
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ButtonEffectOff1());
    }

    IEnumerator ButtonEffectOff2()
    {
        GameObject button = GameObject.Find("Quit");
        Image image = button.GetComponent<Image>();
        image.enabled = false;
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ButtonEffectOn2());
    }

    IEnumerator ButtonEffectOn2()
    {
        GameObject button = GameObject.Find("Quit");
        Image image = button.GetComponent<Image>();
        image.enabled = true;
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(ButtonEffectOff2());
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
