using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocker1swamp : MonoBehaviour
{

    public GameObject lvl2detector;
    public GameObject stars1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("unlocklevel2").activeSelf==true)
        {
            gameObject.SetActive(false);

            lvl2detector.GetComponent<BoxCollider2D>().enabled = true;
            stars1.SetActive(true);
        }
    }
}
