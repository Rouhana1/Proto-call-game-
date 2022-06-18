using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker2jungle : MonoBehaviour
{

    public GameObject lvl3detector;

    public GameObject stars2;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl3burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl3detector.GetComponent<BoxCollider2D>().enabled = true;

                stars2.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl3space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl3detector.GetComponent<BoxCollider2D>().enabled = true;

                stars2.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl3jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl3detector.GetComponent<BoxCollider2D>().enabled = true;

                stars2.SetActive(true);
            }
        }
    }
}
