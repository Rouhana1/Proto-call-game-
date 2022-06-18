using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker6jungle : MonoBehaviour
{

    public GameObject lvl7detector;

    public GameObject stars6;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl7burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl7detector.GetComponent<BoxCollider2D>().enabled = true;

                stars6.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl7space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl7detector.GetComponent<BoxCollider2D>().enabled = true;

                stars6.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl7jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl7detector.GetComponent<BoxCollider2D>().enabled = true;

                stars6.SetActive(true);
            }
        }
    }
}
