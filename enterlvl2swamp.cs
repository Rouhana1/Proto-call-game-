using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class enterlvl2swamp : MonoBehaviour



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

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("music");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);



            StartCoroutine(clicker());


        }

    }

    private IEnumerator clicker()
    {
        replacement.SetActive(true);
        yield return new WaitForSeconds(.1f);
        replacement.SetActive(false);

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("JungleMenur"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl2jungle");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl2burrow");


        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl2space");

        }
        else
        {
            SceneManager.LoadScene("lvlez1");
            yield return null;
        }
       




    }



}
