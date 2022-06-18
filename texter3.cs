using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class texter3 : MonoBehaviour



{


    public GameObject replacement;

    public GameObject tuter;

    public GameObject menu;

    public GameObject red;

    

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



        }

    }

    private IEnumerator clicker()
    {

        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);
        yield return new WaitForSecondsRealtime(.1f);
        menu.SetActive(false);
        yield return new WaitForSecondsRealtime(.2f);
        tuter.GetComponent<tutorial>().enabled = false;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
      
        
        
        





    }








}
