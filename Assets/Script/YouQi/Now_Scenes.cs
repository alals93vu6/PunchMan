using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Now_Scenes : MonoBehaviour
{
    int now;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(now);
        find_scenes();
        DontDestroyOnLoad(this.gameObject);
        change_page();
    }
    void find_scenes()
    {
        now = SceneManager.GetActiveScene().buildIndex;
    }
    void change_page()
    {
        if (now == 0)
        {
            PageDetection.page_now = 1;
        }
        if (now == 3)
        {
            PageDetection.page_now = 2;
        }
        if (now == 4)
        {
            PageDetection.page_now = 3;
        }
    }
}
