using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker3swamp : MonoBehaviour
{

    public GameObject lvl4detector;
    public GameObject stars3;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel4").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl4detector.GetComponent<BoxCollider2D>().enabled = true;
            stars3.SetActive(true);
        }
    }
}
