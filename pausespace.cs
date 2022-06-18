using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class pausespace : MonoBehaviour



{
    public GameObject rocket;

    public GameObject replacement;

    public GameObject pausemenu;

    public GameObject settingsbutton;


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
            PauseGame();
            StartCoroutine(clicker());
            



        }

    }

    IEnumerator clicker()
    {
        
        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);
        yield return new WaitForSecondsRealtime(.1f);
        pausemenu.SetActive(true);
        

       
        
        

    }

    private void PauseGame()
    {
        Time.timeScale = 0;

    }

   

}
