using UnityEngine;
using System.Collections;

public class audioswitcher : MonoBehaviour
{
    public bool booty;

    private GameObject[] music;

    void Start()
    {
        booty = true;
        music = GameObject.FindGameObjectsWithTag("gameMusic");
        Destroy(music[1]);
    }

    // Update is called once per frame
    void Awake()
    {
        if(booty == true)
        {
            DontDestroyOnLoad(transform.gameObject);

        }
    }

    private void Update()
    {
        if(GameObject.Find("musicer").GetComponent<musicabool>().musicon == false)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
    }
}