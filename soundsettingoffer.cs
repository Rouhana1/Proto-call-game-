using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soundsettingoffer : MonoBehaviour
{
    public GameObject replacement;
    public GameObject splashsoundobject;
    public GameObject cheersoundobject;
    public GameObject deathsound;
    public GameObject monkeysound;

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

    IEnumerator clicker()
    {


        splashsoundobject.GetComponent<AudioSource>().enabled = true;
        cheersoundobject.GetComponent<AudioSource>().enabled = true;
        deathsound.GetComponent<AudioSource>().enabled = true;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9jungle") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10jungle"))
        {
            monkeysound.GetComponent<AudioSource>().enabled = true;

        }
        

        GameObject.Find("musicer").GetComponent<musicabool>().soundson = true;

        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(true);
        gameObject.SetActive(false);






    }

}
