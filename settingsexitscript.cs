using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class settingsexitscript : MonoBehaviour



{
    public GameObject replacement;

    

    public GameObject settings;

    


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
            StartCoroutine(clicker2());
            
        }
    }

    private IEnumerator clicker2()
    {
        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);
        yield return new WaitForSecondsRealtime(.1f);
        settings.SetActive(false);

    }

    
}