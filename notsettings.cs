using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notsettings : MonoBehaviour
{
    public GameObject replacement1;
    

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("musicer").GetComponent<musicabool>().notificationson == false)
        {
            replacement1.SetActive(true);
            gameObject.SetActive(false);
        }
        if (GameObject.Find("musicer").GetComponent<musicabool>().notificationson == true)
        {
            replacement1.SetActive(false);
            gameObject.SetActive(true);
        }
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



        GameObject.Find("musicer").GetComponent<musicabool>().notificationson = false;
        
        yield return new WaitForSecondsRealtime(.1f);
        replacement1.SetActive(true);
        gameObject.SetActive(false);






    }

}
