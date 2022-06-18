﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class gorillamovement : MonoBehaviour
{

    private bool isMoving;

    private Vector3 origPos, targetPos;

    private float timeToMove = 0.2f;

    private AudioSource audioSource;


    public GameObject player;
    public GameObject fire;

    public GameObject Applause;
    public GameObject SplashSound;

    public Transform AI;
    public bool recording;
    public GameObject RecZone;
    public BoxCollider2D reczonecollider;
    public bool isRewinding = false;
    public GameObject Gameover;
    public BoxCollider2D tilecollider;

    public GameObject Deathsound;
    private Animation animer;

    public GameObject splasher;

    private Animation splash;

    public GameObject happygorilla;

    public GameObject pause;

    public SpriteRenderer downreplacement;
    public SpriteRenderer upreplacement;
    public SpriteRenderer rightreplacement;
    public SpriteRenderer leftreplacement;

    public GameObject RightArrow1;
    public GameObject RightArrow2;
    public GameObject RightArrow3;
    public GameObject RightArrow4;
    public GameObject RightArrow5;
    public GameObject RightArrow6;
    public GameObject RightArrow7;
    public GameObject RightArrow8;

    public GameObject LeftArrow1;
    public GameObject LeftArrow2;
    public GameObject LeftArrow3;
    public GameObject LeftArrow4;
    public GameObject LeftArrow5;
    public GameObject LeftArrow6;
    public GameObject LeftArrow7;
    public GameObject LeftArrow8;

    public GameObject UpArrow1;
    public GameObject UpArrow2;
    public GameObject UpArrow3;
    public GameObject UpArrow4;
    public GameObject UpArrow5;
    public GameObject UpArrow6;
    public GameObject UpArrow7;
    public GameObject UpArrow8;

    public GameObject DownArrow1;
    public GameObject DownArrow2;
    public GameObject DownArrow3;
    public GameObject DownArrow4;
    public GameObject DownArrow5;
    public GameObject DownArrow6;
    public GameObject DownArrow7;
    public GameObject DownArrow8;

    public SpriteRenderer rend;

    public GameObject Rocket;
    public GameObject splasher2;

    public GameObject froggy;

    public GameObject LevelComplete;

    private Animator anim;
    private Animator anim2;

    public GameObject blood;

    bool aremoving;


    public GameObject confetti;

    private bool play1;
    private bool play2;
    private bool play3;
    private bool play4;
    private bool play5;
    private bool play6;
    private bool play7;
    private bool play8;

    public List<KeyCode> history = new List<KeyCode>();


    public float fadeTime = 1.5f;
    public float fadeStart = 0.1f;

    public bool active;

    public GameObject confetti1;

    public bool onup;
    public bool ondown;
    public bool onright;
    public bool onleft;

    public GameObject outofmoves;



    // Start is called before the first frame update
    void Start()
    {
        happygorilla.SetActive(false);
        happygorilla.GetComponent<Animator>().enabled = true;
        happygorilla.GetComponent<Animator>().SetTrigger("cel");
        froggy.GetComponent<Animator>().speed = 0;
        //anim = froggy.GetComponent<Animator>();
        anim2 = blood.GetComponent<Animator>();

        //animer = froggy.GetComponent<Animation>();

        splash = splasher.GetComponent<Animation>();

        audioSource = Deathsound.GetComponent<AudioSource>();


        recording = true;
        play1 = true;
        play2 = true;
        play3 = true;
        play4 = true;
        play5 = true;
        play6 = true;
        play7 = true;
        play8 = true;
        LevelComplete.SetActive(false);

        //confetti1.SetActive(false);





}

private IEnumerator playback1()
    {
        if (recording == true && play1 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow1.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play1 = false;
                StartCoroutine(replaceup());




            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {

                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow1.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play1 = false;
                StartCoroutine(replaceleft());


            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {

                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow1.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play1 = false;

                StartCoroutine(replaceright());


            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {

                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow1.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play1 = false;
                StartCoroutine(replacedown());

            }


        }


        yield return null;

    }


    private IEnumerator playback2()
    {
        if (recording == true && play2 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow2.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play2 = false;
                StartCoroutine(replaceup());





            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow2.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play2 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow2.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play2 = false;
                StartCoroutine(replaceright());



            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow2.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play2 = false;
                StartCoroutine(replacedown());
            }

        }

        yield return null;

    }

    private IEnumerator playback3()
    {
        if (recording == true && play3 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow3.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play3 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow3.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play3 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow3.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play3 = false;
                StartCoroutine(replaceright());
            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow3.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play3 = false;
                StartCoroutine(replacedown());
            }

        }


        yield return null;

    }
    private IEnumerator playback4()
    {
        if (recording == true && play4 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow4.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play4 = false;
                StartCoroutine(replaceup());
            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow4.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play4 = false;
                StartCoroutine(replaceleft());
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow4.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play4 = false;
                StartCoroutine(replaceright());

            }



            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow4.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play4 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }
    private IEnumerator playback5()
    {
        if (recording == true && play5 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow5.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play5 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow5.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play5 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow5.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play5 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow5.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play5 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }
    private IEnumerator playback6()
    {
        if (recording == true && play6 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow6.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play6 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow6.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play6 = false;
                StartCoroutine(replaceleft());

            }



            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow6.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play6 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow6.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play6 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }
    private IEnumerator playback7()
    {
        if (recording == true && play7 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow7.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play7 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow7.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play7 = false;
                StartCoroutine(replaceleft());
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow7.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play7 = false;

                StartCoroutine(replaceright());


            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow7.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play7 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }
    private IEnumerator playback8()
    {
        if (recording == true && play8 == true)
        {
            if (onup == true && Input.GetKey("mouse 0") && !isMoving)
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow8.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play8 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow8.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play8 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow8.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play8 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow8.SetActive(true);
                yield return new WaitForSeconds(.1f);
                play8 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }







    // Update is called once per frame
    void Update()
    {


        
        StartCoroutine(playback1());
        StartCoroutine(playback2());
        StartCoroutine(playback3());
        StartCoroutine(playback4());
        StartCoroutine(playback5());
        StartCoroutine(playback6());
        StartCoroutine(playback7());
        StartCoroutine(playback8());

        if (play8 == false)
        {
            StartCoroutine(delay());
            
        }


        if (recording == true)
        {
            if (onup == true && Input.GetKey("mouse 0"))
            {
                

                //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                StartCoroutine(jumper());


            }
            if (ondown == true && Input.GetKey("mouse 0"))
            {

                
                //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                StartCoroutine(jumper());
            }
            if (onleft == true && Input.GetKey("mouse 0"))
            {
                
                rend.flipX = true;
                froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                StartCoroutine(jumper());

            }
            if (onright == true && Input.GetKey("mouse 0"))
            {
                rend.flipX = false;
                froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                StartCoroutine(jumper());
                

            }
        }


    }




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col == reczonecollider)
        {
            recording = true;
        }

        if (col.gameObject.layer == 5)
        {
            Gameover.SetActive(true);
            froggy.SetActive(false);
            StartCoroutine(splatter());
            


        }
        if (col.gameObject.layer == 4)
        {


            StartCoroutine(lvlcomplete());


            
            StartCoroutine(death());
            confetti1.SetActive(true);


            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1jungle"))
            {
                GameObject.Find("unlocklvl2jungle").GetComponent<unlocklvl2jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2jungle"))
            {
                GameObject.Find("unlocklvl3jungle").GetComponent<unlocklvl3jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3jungle"))
            {
                GameObject.Find("unlocklvl4jungle").GetComponent<unlocklvl4jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4jungle"))
            {
                GameObject.Find("unlocklvl5jungle").GetComponent<unlocklvl5jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5jungle"))
            {
                GameObject.Find("unlocklvl6jungle").GetComponent<unlocklvl6jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6jungle"))
            {
                GameObject.Find("unlocklvl7jungle").GetComponent<unlocklvl7jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7jungle"))
            {
                GameObject.Find("unlocklvl8jungle").GetComponent<unlocklvl8jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8jungle"))
            {
                GameObject.Find("unlocklvl9jungle").GetComponent<unlocklvl9jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9jungle"))
            {
                GameObject.Find("unlocklvl10jungle").GetComponent<unlocklvl10jungle>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10jungle"))
            {
                GameObject.Find("unlockburrow").GetComponent<unlockjungle>().enabled = true;

            }
        }
        if (col.gameObject.layer == 8)
        {

            StartCoroutine(lvlcomplete());
            

            StartCoroutine(death());

        }
        if (col.gameObject.layer == 2)
        {
            //col.gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0);

            col.gameObject.GetComponent<Renderer>().material.color = Color.cyan;

            (col.gameObject.GetComponent("Halo") as Behaviour).enabled = true;

        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col == reczonecollider)
        {
            recording = false;
            RecZone.SetActive(false);
            StartCoroutine(Rep());
        }


        if (col.gameObject.layer == 2)
        {
            //col.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, 0);

            if (fadeStart < fadeTime)
            {
                fadeStart += Time.deltaTime * fadeTime;
                col.gameObject.GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.white, fadeStart);

            }


            (col.gameObject.GetComponent("Halo") as Behaviour).enabled = false;


        }



    }



    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }


    private IEnumerator Rep()
    {
        while (true)
        {


            yield return new WaitForSeconds((float)0.4);


            if (history.Count > 0)
            {
                if (history[0] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());
                }
            }

            yield return new WaitForSeconds((float)0.4);

            UpArrow1.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow1.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow1.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow1.gameObject.GetComponent<Renderer>().material.color = Color.white;

            if (history.Count > 1)
            {
                if (history[1] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());
                }
            }

            yield return new WaitForSeconds((float)0.4);


            UpArrow2.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow2.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow2.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow2.gameObject.GetComponent<Renderer>().material.color = Color.white;


            if (history.Count > 2)
            {
                if (history[2] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());
                }
                if (history[2] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
                if (history[2] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[2] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
            }

            yield return new WaitForSeconds((float)0.4);

            UpArrow3.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow3.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow3.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow3.gameObject.GetComponent<Renderer>().material.color = Color.white;

            if (history.Count > 3)
            {
                if (history[3] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
            }

            yield return new WaitForSeconds((float)0.4);

            UpArrow4.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow4.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow4.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow4.gameObject.GetComponent<Renderer>().material.color = Color.white;


            if (history.Count > 4)
            {
                if (history[4] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());

                }
            }


            yield return new WaitForSeconds((float)0.4);

            UpArrow5.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow5.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow5.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow5.gameObject.GetComponent<Renderer>().material.color = Color.white;

            if (history.Count > 5)
            {
                if (history[5] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());


                }
            }
            yield return new WaitForSeconds((float)0.4);


            UpArrow6.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow6.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow6.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow6.gameObject.GetComponent<Renderer>().material.color = Color.white;

            if (history.Count > 6)
            {
                if (history[6] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[6] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());



                }
                if (history[6] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[6] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());


                }
            }

            yield return new WaitForSeconds((float)0.4);

            UpArrow7.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow7.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow7.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow7.gameObject.GetComponent<Renderer>().material.color = Color.white;

            if (history.Count > 7)
            {
                if (history[7] == KeyCode.W)
                {
                    StartCoroutine(MovePlayer(Vector3.up));
                    UpArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                   // rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[7] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = false;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());



                }
                if (history[7] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //rend.flipX = true;
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[7] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    rend.flipX = true;
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);
                    StartCoroutine(jumper());


                }
            }


            UpArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;




        }







    }

    private IEnumerator lvlcomplete()
    {
        happygorilla.SetActive(true);
        yield return new WaitForSeconds(1);
        LevelComplete.SetActive(true);
        Applause.SetActive(true);
        SplashSound.SetActive(true);
        
        yield return null;


    }


    private IEnumerator jumper()
    {
        froggy.GetComponent<Animator>().speed = 1;
        froggy.GetComponent<Animator>().SetTrigger("jumppls");

        yield return null;



    }

    private IEnumerator splashe()
    {
        yield return new WaitForSeconds((float).1);

        splasher.SetActive(true);
        splasher.GetComponent<Animator>().SetTrigger("splash");
        yield return new WaitForSeconds(1);
        splasher.SetActive(false);
    }

    private IEnumerator splashe2()
    {
        yield return new WaitForSeconds((float).1);

        splasher2.SetActive(true);
        splasher2.GetComponent<Animator>().SetTrigger("splash");
        yield return new WaitForSeconds(1);
        splasher2.SetActive(false);
    }
    private IEnumerator splatter()
    {
        
        blood.SetActive(true);
        anim2.Play("splatter");
        SplashSound.SetActive(false);
        yield return new WaitForSeconds((float)0.3);
        Deathsound.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        Deathsound.SetActive(false);

        Destroy(player);
        



    }

    public IEnumerator replaceright()
    {
        rightreplacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        rightreplacement.enabled = false;
    }

    public IEnumerator replaceleft()
    {
        leftreplacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        leftreplacement.enabled = false;
    }
    public IEnumerator replaceup()
    {
        upreplacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        upreplacement.enabled = false;
    }
    public IEnumerator replacedown()
    {
        downreplacement.enabled = true;
        yield return new WaitForSeconds(.1f);
        downreplacement.enabled = false;
    }

    private IEnumerator death()
    {
        yield return new WaitForSeconds(.2f);
        Destroy(froggy);
    }

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        if (recording==true)
        {
            outofmoves.SetActive(true);

            froggy.SetActive(false);
            StartCoroutine(splatter());

        }
       
    }
   


}