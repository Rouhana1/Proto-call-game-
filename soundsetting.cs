using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class soundsetting : MonoBehaviour
{
    

    public GameObject replacement1;
   

    public GameObject splashsoundobject;
    public GameObject cheersoundobject;
    public GameObject deathsound;
    public GameObject monkeysound;




    // Start is called before the first frame update




    void Start()
    {

       


        if (GameObject.Find("musicer").GetComponent<musicabool>().soundson == false)
        {
            replacement1.SetActive(true);
            gameObject.SetActive(false);
        }
        if (GameObject.Find("musicer").GetComponent<musicabool>().soundson == true)
        {
            replacement1.SetActive(false);
            gameObject.SetActive(true);
        }
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

    IEnumerator clicker()
    {


        splashsoundobject.GetComponent<AudioSource>().enabled = false;
        cheersoundobject.GetComponent<AudioSource>().enabled = false;
        deathsound.GetComponent<AudioSource>().enabled = false;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10jungle"))
        {
            monkeysound.GetComponent<AudioSource>().enabled = false;

        }


        GameObject.Find("musicer").GetComponent<musicabool>().soundson = false;
        yield return new WaitForSecondsRealtime(.1f);
        replacement1.SetActive(true);
        gameObject.SetActive(false);






    }

}

