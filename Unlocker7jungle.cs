using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker7jungle : MonoBehaviour
{

    public GameObject lvl8detector;

    public GameObject stars7;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl8burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl8detector.GetComponent<BoxCollider2D>().enabled = true;

                stars7.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl8space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl8detector.GetComponent<BoxCollider2D>().enabled = true;

                stars7.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl8jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl8detector.GetComponent<BoxCollider2D>().enabled = true;

                stars7.SetActive(true);
            }
        }
    }
}
