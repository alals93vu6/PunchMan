using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<GameStartDetected>(OnGameStartDetected);
        EventBus.Subscribe<QuitGameDetected>(OnQuitGameDetected);
    }

    private void OnQuitGameDetected(QuitGameDetected obj)
    {
        Application.Quit();
        Debug.Log("砍GAME囉");
    }

    private void OnGameStartDetected(GameStartDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
