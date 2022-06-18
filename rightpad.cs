using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rightpad : MonoBehaviour

{
    public GameObject red;

     public SpriteRenderer replacement;

    public GameObject key;

    

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
        red.GetComponent<BallMovement>().onright = true;

        if (Input.GetKey("mouse 0"))

        {

            StartCoroutine(replace());




        }


    }
    void OnMouseExit()
    {
        red.GetComponent<BallMovement>().onright = false;




    }
    public IEnumerator replace()
    {
        replacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        replacement.enabled = false;
    }

  



}
