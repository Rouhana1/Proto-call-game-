using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class sceneswitcherstart : MonoBehaviour



{
    public GameObject rate;

    public GameObject replacement;

    public GameObject settings;

    public GameObject settingsmenu;


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
            ResumeGame();
            StartCoroutine(clicker());




        }

    }

    private IEnumerator clicker()
    {
        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);
        yield return new WaitForSecondsRealtime(.1f);
        SceneManager.LoadScene("WorldsMenu");

    }

    private void ResumeGame()
    {
        Time.timeScale = 1;




    }


}


    
