using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker7swamp : MonoBehaviour
{

    public GameObject lvl8detector;
    public GameObject stars7;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel8").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl8detector.GetComponent<BoxCollider2D>().enabled = true;
            stars7.SetActive(true);

        }
    }
}
