using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker9swamp : MonoBehaviour
{

    public GameObject lvl10detector;
    public GameObject stars9;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel10").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl10detector.GetComponent<BoxCollider2D>().enabled = true;
            stars9.SetActive(true);
        }
    }
}
