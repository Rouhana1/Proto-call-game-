using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlockswampworld : MonoBehaviour
{

    public GameObject swampworlddetector;
  
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (GameObject.Find("unlockswamp").activeSelf == true)
            {
                gameObject.SetActive(false);


               swampworlddetector.GetComponent<BoxCollider2D>().enabled = true;
                
            }
        
       
    }
}
