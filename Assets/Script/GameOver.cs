using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private Button gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = GetComponent<Button>();
        gameOver.onClick.AddListener(BackHomePage);
    }

    private void BackHomePage()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
