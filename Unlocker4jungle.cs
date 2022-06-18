using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker4jungle : MonoBehaviour
{

    public GameObject lvl5detector;

    public GameObject stars4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl5burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl5detector.GetComponent<BoxCollider2D>().enabled = true;

                stars4.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl5space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl5detector.GetComponent<BoxCollider2D>().enabled = true;

                stars4.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl5jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl5detector.GetComponent<BoxCollider2D>().enabled = true;

                stars4.SetActive(true);
            }
        }
    }
}
