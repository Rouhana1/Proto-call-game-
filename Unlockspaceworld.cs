using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlockspaceworld : MonoBehaviour
{

    public GameObject spaceworlddetector;
  
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (GameObject.Find("unlockspace").activeSelf == true)
            {
                gameObject.SetActive(false);


               spaceworlddetector.GetComponent<BoxCollider2D>().enabled = true;
                
            }
        
       
    }
}
