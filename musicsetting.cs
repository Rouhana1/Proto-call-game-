using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicsetting : MonoBehaviour
{
    public GameObject replacement1;

    
    public GameObject music;

    // Start is called before the first frame update
    void Start()
    {
        

        if (GameObject.Find("musicer").GetComponent<musicabool>().musicon == false)
        {
            replacement1.SetActive(true);
            gameObject.SetActive(false);
        }
        if (GameObject.Find("musicer").GetComponent<musicabool>().musicon == true)
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

        music.GetComponent<AudioSource>().enabled = false;

        GameObject.Find("musicer").GetComponent<musicabool>().musicon = false;

        

        yield return new WaitForSecondsRealtime(.1f);
        replacement1.SetActive(true);
        gameObject.SetActive(false);









    }

}

