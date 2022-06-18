using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker5swamp : MonoBehaviour
{

    public GameObject lvl6detector;
    public GameObject stars5;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel6").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl6detector.GetComponent<BoxCollider2D>().enabled = true;
            stars5.SetActive(true);
        }
    }
}
