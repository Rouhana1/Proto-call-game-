using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlocker1jungle : MonoBehaviour
{

    public GameObject lvl2detector;


    public GameObject stars1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlocklvl2burrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl2detector.GetComponent<BoxCollider2D>().enabled = true;

                stars1.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("spacemenu"))
        {
            if (GameObject.Find("unlocklvl2space").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl2detector.GetComponent<BoxCollider2D>().enabled = true;

                stars1.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlocklvl2jungle").activeSelf == true)
            {
                gameObject.SetActive(false);

                lvl2detector.GetComponent<BoxCollider2D>().enabled = true;

                stars1.SetActive(true);
            }
        }
       
    }
}
