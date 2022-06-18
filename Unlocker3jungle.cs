using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker3jungle : MonoBehaviour
{

    public GameObject lvl4detector;

    public GameObject stars3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl4burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl4detector.GetComponent<BoxCollider2D>().enabled = true;

                stars3.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl4space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl4detector.GetComponent<BoxCollider2D>().enabled = true;

                stars3.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl4jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl4detector.GetComponent<BoxCollider2D>().enabled = true;

                stars3.SetActive(true);
            }
        }
    }
}
