using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker4swamp : MonoBehaviour
{

    public GameObject lvl5detector;
    public GameObject stars4;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel5").activeSelf == true)
        {
            gameObject.SetActive(false);

            lvl5detector.GetComponent<BoxCollider2D>().enabled = true;
            stars4.SetActive(true);
        }
    }
}
