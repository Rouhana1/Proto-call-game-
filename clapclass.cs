using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clapclass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("musicer").GetComponent<musicabool>().soundson == false)
        {
            print("soundoffffffffff");
            gameObject.GetComponent<AudioSource>().enabled = false;
            
        }
        else
        {
            print("soundonnnnnnnnnn");
            gameObject.GetComponent<AudioSource>().enabled = true;

        }

    }
}
