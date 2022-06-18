using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker6swamp : MonoBehaviour
{

    public GameObject lvl7detector;
    public GameObject stars6;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel7").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl7detector.GetComponent<BoxCollider2D>().enabled = true;
            stars6.SetActive(true);
        }
    }
}
