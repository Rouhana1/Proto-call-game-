using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class tutorial : MonoBehaviour
{

    public GameObject red;

    public GameObject text1;



    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(true);
        StartCoroutine(Ye());
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public IEnumerator Ye()
    {



        yield return new WaitForSeconds(1);
        red.GetComponent<BallMovement>().history.Add(KeyCode.D);
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.right));
        StartCoroutine(red.GetComponent<BallMovement>().replaceright());
        red.GetComponent<BallMovement>().RightArrow1.SetActive(true);
        yield return new WaitForSeconds(1);

    


        StartCoroutine(red.GetComponent<BallMovement>().replaceup());
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.up));
        red.GetComponent<BallMovement>().history.Add(KeyCode.W);
        red.GetComponent<BallMovement>().UpArrow2.SetActive(true);
        yield return new WaitForSeconds(1);

    

        StartCoroutine(red.GetComponent<BallMovement>().replaceright());
        red.GetComponent<BallMovement>().history.Add(KeyCode.D);
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.right));
        red.GetComponent<BallMovement>().RightArrow3.SetActive(true);
        yield return new WaitForSeconds(1);


        StartCoroutine(red.GetComponent<BallMovement>().replaceright());
        red.GetComponent<BallMovement>().history.Add(KeyCode.D);
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.right));
        red.GetComponent<BallMovement>().RightArrow4.SetActive(true);
        yield return new WaitForSeconds(1);


        StartCoroutine(red.GetComponent<BallMovement>().replacedown());
        red.GetComponent<BallMovement>().history.Add(KeyCode.S);
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.down));
        red.GetComponent<BallMovement>().DownArrow5.SetActive(true);
        yield return new WaitForSeconds(1);


        StartCoroutine(red.GetComponent<BallMovement>().replaceright());
        red.GetComponent<BallMovement>().history.Add(KeyCode.D);
        StartCoroutine(red.GetComponent<BallMovement>().MovePlayer(Vector3.right));
        red.GetComponent<BallMovement>().RightArrow6.SetActive(true);
        yield return new WaitForSeconds(1);


       

    }
   
}






