using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker9jungle : MonoBehaviour
{

    public GameObject lvl10detector;
    public GameObject stars9;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl10burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl10detector.GetComponent<BoxCollider2D>().enabled = true;

                stars9.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl10space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl10detector.GetComponent<BoxCollider2D>().enabled = true;

                stars9.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl10jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl10detector.GetComponent<BoxCollider2D>().enabled = true;

                stars9.SetActive(true);
            }
        }
    }
}
