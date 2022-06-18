using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class resume : MonoBehaviour



{
   

    public GameObject replacement;

    public GameObject settings;

    public GameObject pausemenu;

 


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
            


        }

    }

   private IEnumerator clicker()
    {

        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);
        yield return new WaitForSecondsRealtime(.1f);

        pausemenu.SetActive(false);


    }



    private void ResumeGame()
    {
        Time.timeScale = 1;

        StartCoroutine(clicker());


    }
  



}
