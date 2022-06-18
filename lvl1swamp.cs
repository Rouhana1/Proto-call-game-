using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;






public class lvl1swamp : MonoBehaviour



{
    

    public GameObject replacement;

    public GameObject settings;

   





    // Start is called before the first frame update
    void srart()
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
        
        SceneManager.LoadScene("Level1");
        yield return null;




    }

   

}
