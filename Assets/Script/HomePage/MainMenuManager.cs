using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private PageRotaryB pageRotary;
    // Start is called before the first frame update
    void Start()
    {
        pageRotary = GetComponent<PageRotaryB>();
        
        EventBus.Subscribe<GameStartDetected>(OnGameStartDetected);
        EventBus.Subscribe<QuitGameDetected>(OnQuitGameDetected);
        EventBus.Subscribe<HitShopDetected>(OnHitShopDetected);
        EventBus.Subscribe<PageLeftMoveDetected>(OnPageLeftMoveDetected);
        EventBus.Subscribe<PageRightMoveDetected>(OnPageRightMoveDetected);
        
    }

    private void OnPageRightMoveDetected(PageRightMoveDetected obj)
    {
        pageRotary.PageRightMOve();
    }

    private void OnPageLeftMoveDetected(PageLeftMoveDetected obj)
    {
        pageRotary.PageLeftMove();
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

    

    private void OnHitShopDetected(HitShopDetected obj)
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
