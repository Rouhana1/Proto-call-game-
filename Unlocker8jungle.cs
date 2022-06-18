using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker8jungle : MonoBehaviour
{

    public GameObject lvl9detector;

    public GameObject stars8;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl9burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl9detector.GetComponent<BoxCollider2D>().enabled = true;

                stars8.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl9space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl9detector.GetComponent<BoxCollider2D>().enabled = true;

                stars8.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl9jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl9detector.GetComponent<BoxCollider2D>().enabled = true;

                stars8.SetActive(true);
            }
        }
    }
}
