using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject first;
    public int now = 0;
    void Start()
    {
        first.SetActive(true);
    }

    public void Next()
    {
        transform.Find("Image"+now.ToString()).gameObject.SetActive(false);
        now++;
        transform.Find("Image"+now.ToString()).gameObject.SetActive(true);
    }

    public void Back()
    {
        transform.Find("Image"+now.ToString()).gameObject.SetActive(false);
        now--;
        transform.Find("Image"+now.ToString()).gameObject.SetActive(true);
    }

    public void Home()
    {
        SceneManager.LoadScene("Start");
    }
}
