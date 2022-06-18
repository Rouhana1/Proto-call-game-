using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlockburrowworld : MonoBehaviour
{

    public GameObject burrowworlddetector;
  
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (GameObject.Find("unlockburrow").activeSelf == true)
            {
                gameObject.SetActive(false);


               burrowworlddetector.GetComponent<BoxCollider2D>().enabled = true;
                
            }
        
       
    }
}
