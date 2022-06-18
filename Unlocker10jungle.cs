using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlocker10jungle : MonoBehaviour
{

    
    public GameObject stars10;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BurrowMenu"))
        {
            if (GameObject.Find("unlockspace").activeSelf == true)
            {
                gameObject.SetActive(false);

               

                stars10.SetActive(true);
            }
        }
        else
        {
            if (GameObject.Find("unlockburrow").activeSelf == true)
            {
                gameObject.SetActive(false);

                

                stars10.SetActive(true);
            }
        }
    }
}
