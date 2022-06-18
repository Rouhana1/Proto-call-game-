using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialenter : MonoBehaviour
{
    public GameObject replacement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetKey("mouse 0"))

        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("music");
            foreach (GameObject enemy in enemies)
                GameObject.Destroy(enemy);


            StartCoroutine(clicker());
            


        }

    }

    private IEnumerator clicker()
    {
        replacement.SetActive(true);
        yield return new WaitForSeconds(.1f);
        replacement.SetActive(false);
        yield return new WaitForSeconds(.12f);
        SceneManager.LoadScene("tutorial");
    }


}
