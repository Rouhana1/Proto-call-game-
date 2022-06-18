using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{

    private bool isMoving;

    public GameObject Splashsound;
    public GameObject Deathsound;
    public GameObject Applause;
    public GameObject outofmoves;

    private Vector3 origPos, targetPos;

    private float timeToMove = 0.2f;

    public bool tut;

    private AudioSource audioSource;

    public GameObject splasher4;
    public GameObject splasher5;

    public GameObject test;
    public GameObject splasher3;

    public GameObject player;
    public GameObject fire;

    public GameObject righter;

    private bool tut2;

    public Transform AI;
    public bool recording;
    public GameObject RecZone;
    public BoxCollider2D reczonecollider;
    public bool isRewinding = false;
    public GameObject Gameover;
    public BoxCollider2D tilecollider;

    private Animation animer;

    public GameObject splasher;

    private Animation splash;

    public GameObject pause;

    public SpriteRenderer downreplacement;
    public SpriteRenderer upreplacement;
    public SpriteRenderer rightreplacement;
    public SpriteRenderer leftreplacement;

    public GameObject key;

    public bool fast;




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

    public bool onup;
    public bool ondown;
    public bool onright;
    public bool onleft;



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
    public GameObject confetti2;

    private GameObject[] music;

   
    // Start is called before the first frame update
    void Start()
    {
        audioSource = Deathsound.GetComponent<AudioSource>();
        fast = false;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
        {
            rend.flipX = true;

        }
        recording = true;

        fire.SetActive(false);


        anim = froggy.GetComponent<Animator>();
        anim2 = blood.GetComponent<Animator>();

        animer = froggy.GetComponent<Animation>();

        splasher2.GetComponent<Animator>().enabled = false;

        splasher.GetComponent<Animator>().enabled=true;





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

    private void FixedUpdate()
    {
        if (fast == true)
        {
            Time.timeScale = 2;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    private IEnumerator playback1()
    {
        if (recording == true && play1 == true)
        {
            if (onup==true && Input.GetKey("mouse 0") && !isMoving )
            {

                StartCoroutine(MovePlayer(Vector3.up));
                history.Add(KeyCode.W);
                UpArrow1.SetActive(true);
                StartCoroutine(stall());
                play1 = false;
                StartCoroutine(replaceup());




            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {

                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow1.SetActive(true);
                StartCoroutine(stall());
                play1 = false;
                StartCoroutine(replaceleft());


            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {

                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow1.SetActive(true);
                StartCoroutine(stall());
                play1 = false;
                
                StartCoroutine(replaceright());


            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {

                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow1.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play2 = false;
                StartCoroutine(replaceup());
                




            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow2.SetActive(true);
                StartCoroutine(stall());
                play2 = false;
                StartCoroutine(replaceleft());
                
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving )
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow2.SetActive(true);
                StartCoroutine(stall());
                play2 = false;
                StartCoroutine(replaceright());
               


            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow2.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play3 = false;
                StartCoroutine(replaceup());
                
            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow3.SetActive(true);
                StartCoroutine(stall());
                play3 = false;
                StartCoroutine(replaceleft());
               
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow3.SetActive(true);
                StartCoroutine(stall());
                play3 = false;
                StartCoroutine(replaceright());
            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow3.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play4 = false;
                StartCoroutine(replaceup());
            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow4.SetActive(true);
                StartCoroutine(stall());
                play4 = false;
                StartCoroutine(replaceleft());
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow4.SetActive(true);
                StartCoroutine(stall());
                play4 = false;
                StartCoroutine(replaceright());

            }



            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow4.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play5 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow5.SetActive(true);
                StartCoroutine(stall());
                play5 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow5.SetActive(true);
                StartCoroutine(stall());
                play5 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow5.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play6 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow6.SetActive(true);
                StartCoroutine(stall());
                play6 = false;
                StartCoroutine(replaceleft());

            }



            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow6.SetActive(true);
                StartCoroutine(stall());
                play6 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow6.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play7 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow7.SetActive(true);
                StartCoroutine(stall());
                play7 = false;
                StartCoroutine(replaceleft());
            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow7.SetActive(true);
                StartCoroutine(stall());
                play7 = false;

                StartCoroutine(replaceright());


            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow7.SetActive(true);
                StartCoroutine(stall());
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
                StartCoroutine(stall());
                play8 = false;
                StartCoroutine(replaceup());

            }

            else if (onleft == true && Input.GetKey("mouse 0") && !isMoving)

            {
                StartCoroutine(MovePlayer(Vector3.left));
                history.Add(KeyCode.A);
                LeftArrow8.SetActive(true);
                StartCoroutine(stall());
                play8 = false;
                StartCoroutine(replaceleft());

            }


            else if (onright == true && Input.GetKey("mouse 0") && !isMoving)
            {
                history.Add(KeyCode.D);
                StartCoroutine(MovePlayer(Vector3.right));
                RightArrow8.SetActive(true);
                StartCoroutine(stall());
                play8 = false;
                StartCoroutine(replaceright());

            }


            else if (ondown == true && Input.GetKey("mouse 0") && !isMoving)

            {
                history.Add(KeyCode.S);
                StartCoroutine(MovePlayer(Vector3.down));
                DownArrow8.SetActive(true);
                StartCoroutine(stall());
                play8 = false;
                StartCoroutine(replacedown());

            }

        }

        yield return null;

    }








    // Update is called once per frame
    void Update()
    {
        if (play8 == false)
        {
            StartCoroutine(delay());

        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("tutorial"))
        {
            tut = true;

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("tutorial2"))
        {
            tut2 = true;

        }



        StartCoroutine(playback1());
        StartCoroutine(playback2());
        StartCoroutine(playback3());
        StartCoroutine(playback4());
        StartCoroutine(playback5());
        StartCoroutine(playback6());
        StartCoroutine(playback7());
        StartCoroutine(playback8());

        if (recording == true)
        {
            if (onup == true && Input.GetKey("mouse 0"))
            {
                StartCoroutine(jumper());
                

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                {
                    froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                }
                
                


            }
            if (ondown == true && Input.GetKey("mouse 0"))
            {
                StartCoroutine(jumper());
                

                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                {
                    froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                }
                
                
            }
            if (onleft == true && Input.GetKey("mouse 0"))
            {
                StartCoroutine(jumper());
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                {
                    rend.flipX = false;

                }
                else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                {
                    froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                }
                else
                {
                    rend.flipX = true;
                }
                
                
            }
            if (onright == true && Input.GetKey("mouse 0"))
            {
                StartCoroutine(jumper());
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                {
                    rend.flipX = true;

                }
                else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                {
                    froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                }
                else
                {
                    rend.flipX = false;
                }
                
                
            }
        }


       

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 10)
        {
            recording = true;
        }

        if (col.gameObject.layer == 5)
        {
            
            froggy.SetActive(false);
            StartCoroutine(splatter());
            
           
            
            


        }
        if (col.gameObject.layer == 4)
        {

            if(tut==true)
            {
                
                StartCoroutine(splashe2());
                StartCoroutine(death());
                
                StartCoroutine(confettier());
                StartCoroutine(replay());

            }

            if (tut2==true)
            {
                StartCoroutine(splashe2());
                StartCoroutine(death());
                StartCoroutine(confettier());
                StartCoroutine(lvlcomplete());

            }
            

            else
            {
                StartCoroutine(lvlcomplete());
                StartCoroutine(splashe());
                StartCoroutine(death());
                StartCoroutine(confettier());
                Splashsound.SetActive(true);
                
                
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("tutorial2"))
            {
                GameObject.Find("unlockswamp").GetComponent<unlockswamp>().enabled = true;

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
            {
                GameObject.Find("unlocklevel2").GetComponent<unlocklvl2>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1"))
            {
                GameObject.Find("unlocklevel3").GetComponent<unlocklvl3>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2"))
            {
                GameObject.Find("unlocklevel4").GetComponent<unlocklvl4>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3"))
            {
                GameObject.Find("unlocklevel5").GetComponent<unlocklvl5>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4"))
            {
                GameObject.Find("unlocklevel6").GetComponent<unlocklvl6>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5"))
            {
                GameObject.Find("unlocklevel7").GetComponent<unlocklvl7>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1"))
            {
                GameObject.Find("unlocklevel8").GetComponent<unlocklvl8>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8"))
            {
                GameObject.Find("unlocklevel9").GetComponent<unlocklvl9>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9"))
            {
                GameObject.Find("unlocklevel10").GetComponent<unlocklvl10>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
            {
                GameObject.Find("unlockjungle").GetComponent<unlockjungle>().enabled = true;

            }


            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1burrow"))
            {
                GameObject.Find("unlocklvl2burrow").GetComponent<unlocklvl2>().enabled = true;

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2burrow"))
            {
                GameObject.Find("unlocklvl3burrow").GetComponent<unlocklvl3>().enabled = true;

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3burrow"))
            {
                GameObject.Find("unlocklvl4burrow").GetComponent<unlocklvl4>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4burrow"))
            {
                GameObject.Find("unlocklvl5burrow").GetComponent<unlocklvl5>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5burrow"))
            {
                GameObject.Find("unlocklvl6burrow").GetComponent<unlocklvl6>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6burrow"))
            {
                GameObject.Find("unlocklvl7burrow").GetComponent<unlocklvl7>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7burrow"))
            {
                GameObject.Find("unlocklvl8burrow").GetComponent<unlocklvl8>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8burrow"))
            {
                GameObject.Find("unlocklvl9burrow").GetComponent<unlocklvl9>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9burrow"))
            {
                GameObject.Find("unlocklvl10burrow").GetComponent<unlocklvl10>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10burrow"))
            {
                GameObject.Find("unlockspace").GetComponent<unlockspace>().enabled = true;

            }


            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space"))
            {
                GameObject.Find("unlocklvl2space").GetComponent<unlocklvl2>().enabled = true;

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space"))
            {
                GameObject.Find("unlocklvl3space").GetComponent<unlocklvl3>().enabled = true;

            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space"))
            {
                GameObject.Find("unlocklvl4space").GetComponent<unlocklvl4>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space"))
            {
                GameObject.Find("unlocklvl5space").GetComponent<unlocklvl5>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space"))
            {
                GameObject.Find("unlocklvl6space").GetComponent<unlocklvl6>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space"))
            {
                GameObject.Find("unlocklvl7space").GetComponent<unlocklvl7>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space"))
            {
                GameObject.Find("unlocklvl8space").GetComponent<unlocklvl8>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space"))
            {
                GameObject.Find("unlocklvl9space").GetComponent<unlocklvl9>().enabled = true;

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space"))
            {
                GameObject.Find("unlocklvl10space").GetComponent<unlocklvl10>().enabled = true;

            }
            



        }

        if (col.gameObject.layer == 9)
        {
            StartCoroutine(lvlcomplete());
            StartCoroutine(splashe3());
            StartCoroutine(death());
            StartCoroutine(confettier());
            Splashsound.SetActive(true);
        }
        if (col.gameObject.layer == 11)
        {
            StartCoroutine(lvlcomplete());
            StartCoroutine(splashe4());
            StartCoroutine(death());
            StartCoroutine(confettier());
            Splashsound.SetActive(true);
        }
        if (col.gameObject.layer == 12)
        {
            StartCoroutine(lvlcomplete());
            StartCoroutine(splashe5());
            StartCoroutine(death());
            StartCoroutine(confettier());
            Splashsound.SetActive(true);
        }
        if (col.gameObject.layer == 8)
        {

            //StartCoroutine(splashe2());
            //StartCoroutine(lvlcomplete());


            
            //StartCoroutine(death());

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
        if (col.gameObject.layer == 10)
        {
            recording = false;
            col.GetComponent<EdgeCollider2D>().enabled = false;
            StartCoroutine(Rep());
        }
        if (col==reczonecollider)
        {
            recording = false;
            col.GetComponent<BoxCollider2D>().enabled = false;
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



    public IEnumerator MovePlayer(Vector3 direction)
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


    public IEnumerator Rep()
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }

                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    
                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());
                }
                if (history[0] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow1.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
                   
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[1] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow2.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
                    
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());
                }
                if (history[2] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    
                    StartCoroutine(jumper());

                }
                if (history[2] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[2] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow3.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                   
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[3] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow4.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());

                }
                if (history[4] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow5.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[5] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow6.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[6] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    StartCoroutine(jumper());



                }
                if (history[6] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[6] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow7.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
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
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 0);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, 90);
                    StartCoroutine(jumper());


                }
                if (history[7] == KeyCode.D)
                {
                    StartCoroutine(MovePlayer(Vector3.right));
                    RightArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = true;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, -90);

                    }
                    else
                    {
                        rend.flipX = false;
                    }
                    StartCoroutine(jumper());



                }
                if (history[7] == KeyCode.S)
                {
                    StartCoroutine(MovePlayer(Vector3.down));
                    DownArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 180);

                    }
                    //froggy.transform.eulerAngles = new Vector3(0, 0, -90);
                    StartCoroutine(jumper());


                }
                if (history[7] == KeyCode.A)
                {
                    StartCoroutine(MovePlayer(Vector3.left));
                    LeftArrow8.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
                    {
                        rend.flipX = false;

                    }
                    else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9space") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10space"))
                    {
                        froggy.transform.eulerAngles = new Vector3(0, 0, 90);

                    }
                    else
                    {
                        rend.flipX = true;
                    }
                    StartCoroutine(jumper());


                }
            }


            UpArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            RightArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            DownArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;
            LeftArrow8.gameObject.GetComponent<Renderer>().material.color = Color.white;




        }







    }

    public IEnumerator lvlcomplete()
    {
        yield return new WaitForSeconds(1);
        LevelComplete.SetActive(true);
        Applause.SetActive(true);
        yield return null;


    }

    void LateUpdate()
    {
        GameObject[] Cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject Cube in Cubes)
        {
            if (Cube.GetComponent<Rigidbody2D>() == null)
            {
                continue;
            }
            if (Cube.GetComponent<Rigidbody2D>().velocity.magnitude > 0.01)
            {
                aremoving = true;

            }
            if (Cube.GetComponent<Rigidbody2D>().velocity.magnitude <= 0.01)
            {
                aremoving = false;
                
            }
        }
    }

    public IEnumerator jumper()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl1burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl3burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl4burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl5burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl7burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl8burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl9burrow") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl10burrow"))
        {

            froggy.GetComponent<Animator>().SetTrigger("jump");
        }
        else
        {
            fire.SetActive(true);

            fire.GetComponent<Animator>().SetTrigger("go");
            yield return new WaitForSeconds(.3f);
            fire.SetActive(false);
        }
        

        




        yield return null;






    }

    public IEnumerator splashe()
    {
        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez4") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlez5") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvlmed1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level8") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level9") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level10"))
        {

            splasher.SetActive(true);

            splasher.GetComponent<Animator>().SetTrigger("splash");
            yield return new WaitForSeconds(.5f);
            splasher.SetActive(false);
        }
        else
        {
            splasher.SetActive(true);

            splasher.GetComponent<Animator>().SetTrigger("splash");
            yield return new WaitForSeconds(2f);
            splasher.SetActive(false);
        }
        
    }

    public IEnumerator splashe3()
    {
        

        splasher3.SetActive(true);

        splasher3.GetComponent<Animator>().SetTrigger("splash");
        yield return new WaitForSeconds(.5f);
        splasher3.SetActive(false);
    }
    public IEnumerator splashe4()
    {
        

        splasher4.SetActive(true);

        splasher4.GetComponent<Animator>().SetTrigger("splash");
        yield return new WaitForSeconds(.5f);
        splasher4.SetActive(false);
    }
    public IEnumerator splashe5()
    {
        

        splasher5.SetActive(true);

        splasher5.GetComponent<Animator>().SetTrigger("splash");
        yield return new WaitForSeconds(.5f);
        splasher5.SetActive(false);
    }




    public IEnumerator splashe2()
    {
        yield return new WaitForSeconds((float).1);

        
        splasher2.GetComponent<Animator>().enabled=true;

        splasher2.GetComponent<Animator>().SetTrigger("splash");
        
        //splasher2.SetActive(false);
    }
    public IEnumerator splatter()
    {
        history = new List<KeyCode>();
        blood.SetActive(true);
        anim2.Play("splatter");
        yield return new WaitForSeconds(.5f);
        Destroy(froggy);
        Destroy(blood);
        Deathsound.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        Deathsound.SetActive(false);

        yield return new WaitForSeconds(.1f);



        Gameover.SetActive(true);
        




    }
    public IEnumerator splatter2()
    {

        Deathsound.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        Deathsound.SetActive(false);
        blood.SetActive(true);
        anim2.Play("splatter");


        yield return new WaitForSeconds((float)0.3);
        
        Destroy(player);
        






    }
    public IEnumerator death()
    {
        yield return new WaitForSeconds(.1f);
        Destroy(froggy);
        Destroy(key);
    }

    public IEnumerator stall()
    {
        yield return new WaitForSeconds(.1f);
        yield return null;
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

    public IEnumerator replay()

    {
        yield return new WaitForSeconds(.5f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public IEnumerator Gameover1()
    {
        yield return new WaitForSeconds(.5f);
        
        Gameover.SetActive(true);


    }

    public IEnumerator confettier()
    {
        confetti1.SetActive(true);
        yield return new WaitForSeconds(.7f);
        confetti2.SetActive(true);
        

    }

    

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        if (recording == true)
        {
            outofmoves.SetActive(true);

            StartCoroutine(splatter2());

            
            
           

        }

    }
   


}















  

