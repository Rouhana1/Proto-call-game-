using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker8swamp : MonoBehaviour
{

    public GameObject lvl9detector;
    public GameObject stars8;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel9").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl9detector.GetComponent<BoxCollider2D>().enabled = true;
            stars8.SetActive(true);
        }
    }
}
