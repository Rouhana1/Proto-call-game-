﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class leftpad : MonoBehaviour

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
        red.GetComponent<BallMovement>().onleft = true;

        if (Input.GetKey("mouse 0"))

        {

            StartCoroutine(replace());




        }


    }
    void OnMouseExit()
    {
        red.GetComponent<BallMovement>().onleft = false;




    }

    public IEnumerator replace()
    {
        replacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        replacement.enabled = false;
    }


}
