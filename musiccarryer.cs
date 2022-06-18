using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiccarryer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("musicer").GetComponent<musicabool>().musicon == false)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        

    }
}
