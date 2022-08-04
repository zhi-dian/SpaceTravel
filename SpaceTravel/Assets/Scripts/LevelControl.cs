using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    // Start is called before the first frame update

    public string resume;
    public string home;
    void Resume()
    {
        SceneManager.LoadScene(resume);
    }

    void Home()
    {
        SceneManager.LoadScene(home);
    }
}
