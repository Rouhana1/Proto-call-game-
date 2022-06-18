using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl6to7 : MonoBehaviour
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
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6jungle"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl7jungle");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6burrow"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl7burrow");

        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("lvl6space"))
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvl7space");

        }
        else
        {
            yield return new WaitForSeconds(.12f);
            SceneManager.LoadScene("lvlmed1");

        }
        
    }

}
