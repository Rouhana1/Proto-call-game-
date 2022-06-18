﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl5to6 : MonoBehaviour
{
    public GameObject replacement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetKey("mouse 0"))

        {
            StartCoroutine(clicker());
            StartCoroutine(switchdelay());


        }

    }

    private IEnumerator clicker()
    {
        replacement.SetActive(true);
        yield return new WaitForSeconds(.1f);
        replacement.SetActive(false);

    }

    private IEnumerator switchdelay()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5jungle"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl6jungle");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5burrow"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl6burrow");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl6space");

        }
        else
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvlez5");
        }
        
    }

}
