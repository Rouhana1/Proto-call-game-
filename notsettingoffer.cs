using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notsettingoffer : MonoBehaviour
{
    public GameObject replacement;


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
        if (Input.GetKey("mouse 0"))

        {

            StartCoroutine(clicker());




        }

    }

    IEnumerator clicker()
    {


        GameObject.Find("musicer").GetComponent<musicabool>().notificationson = true;

        yield return new WaitForSecondsRealtime(.1f);
        replacement.SetActive(true);
        gameObject.SetActive(false);






    }

}
