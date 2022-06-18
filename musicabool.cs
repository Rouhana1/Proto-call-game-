using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicabool : MonoBehaviour
{
    public bool musicon;
    public bool soundson;
    public bool notificationson;

    private static Player playerInstance;

    // Start is called before the first frame update
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<musicabool>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        // if more then one music player is in the scene
        //destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soundson == false)
        {
            print("soundoff");
            GameObject.Find("splashsound").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("applausesound").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("deathsound").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("monkeysound").GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            print("soundon");
            GameObject.Find("splashsound").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("applausesound").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("deathsound").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("monkeysound").GetComponent<AudioSource>().enabled = true;
        }
    }
}
