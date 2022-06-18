using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotation : MonoBehaviour


    
{
    public GameObject banana;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
            banana.transform.Rotate(5, 0, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
        
    }
}
