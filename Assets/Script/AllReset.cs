using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            PlayerPrefs.SetInt("NowGameLV",1);
            PlayerPrefs.SetInt("PlayerMoney",0);
            UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
        }
    }
}
