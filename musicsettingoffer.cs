using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicsettingoffer : MonoBehaviour
{
    public GameObject replacement;
    public GameObject music;


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


        music.GetComponent<AudioSource>().enabled = true;

        GameObject.Find("musicer").GetComponent<musicabool>().musicon = true;

        yield return new WaitForSecondsRealtime(.1f);

        replacement.SetActive(true);
        gameObject.SetActive(false);







    }

}
