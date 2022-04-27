using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour
{
    private Button gameStartButton;
    
    // Start is called before the first frame update
    void Start()
    {
        gameStartButton = GetComponent<Button>();
        gameStartButton.onClick.AddListener(GameStart);
        
    }

    private void GameStart()
    {
        EventBus.Post(new GameStartDetected());
    }
    
}
