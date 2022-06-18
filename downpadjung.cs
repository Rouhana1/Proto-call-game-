using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class downpadjung : MonoBehaviour

{
    public SpriteRenderer replacement;

    public GameObject red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        red.GetComponent<gorillamovement>().ondown = true;

        if (Input.GetKey("mouse 0"))

        {

            StartCoroutine(replace());




        }


    }
    void OnMouseExit()
    {
        red.GetComponent<gorillamovement>().ondown = false;




    }

    public IEnumerator replace()
    {
        replacement.enabled=true;
        yield return new WaitForSeconds(.1f);
        replacement.enabled = false;
    }

    
}
