using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class settingsswitcher : MonoBehaviour



{
    public GameObject replacement;

    public GameObject play;

    public GameObject settings;

    public GameObject senu;


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
            StartCoroutine(switchdelay2());
        }
    }

    private IEnumerator clicker2()
    {
        replacement.SetActive(true);
        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(false);

    }

    private IEnumerator switchdelay2()
    {
        yield return new WaitForSecondsRealtime(.1f);
        settings.SetActive(true);
    }
}