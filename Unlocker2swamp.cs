using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker2swamp : MonoBehaviour
{

    public GameObject lvl3detector;
    public GameObject stars2;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel3").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl3detector.GetComponent<BoxCollider2D>().enabled = true;
            stars2.SetActive(true);
        }
    }
}
