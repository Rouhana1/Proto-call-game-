using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker5jungle : MonoBehaviour
{

    public GameObject lvl6detector;
    public GameObject stars5;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl6burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl6detector.GetComponent<BoxCollider2D>().enabled = true;

                stars5.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl6space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl6detector.GetComponent<BoxCollider2D>().enabled = true;

                stars5.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl6jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl6detector.GetComponent<BoxCollider2D>().enabled = true;

                stars5.SetActive(true);
            }
        }
    }
}
