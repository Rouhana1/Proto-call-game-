using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl2to3 : MonoBehaviour
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
            StartCoroutine(clicker());
            StartCoroutine(switchdelay());


        }

    }

    private IEnumerator clicker()
    {
        replacement.SetActive(true);
        yield return new WaitForSeconds(.1f);
        replacement.SetActive(false);

    }

    private IEnumerator switchdelay()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2jungle"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl3jungle");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2burrow"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl3burrow");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl2space"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl3space");

        }
        else
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvlez2");

        }


    }

}
