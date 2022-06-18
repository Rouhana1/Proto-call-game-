using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unlockjungleworld : MonoBehaviour
{

    public GameObject jungleworlddetector;
  
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (GameObject.Find("unlockjungle").activeSelf == true)
            {
                gameObject.SetActive(false);


               jungleworlddetector.GetComponent<BoxCollider2D>().enabled = true;
                
            }
        
       
    }
}
