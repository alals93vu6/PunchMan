using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private PageRotaryB pageRotary;

    private HomePageUIManager homePageUIManager;
    // Start is called before the first frame update
    void Start()
    {
        pageRotary = GetComponent<PageRotaryB>();
        homePageUIManager = GetComponent<HomePageUIManager>();
        EventBus.Subscribe<GameStartDetected>(OnGameStartDetected);
        EventBus.Subscribe<QuitGameDetected>(OnQuitGameDetected);
        EventBus.Subscribe<HitShopDetected>(OnHitShopDetected);
        EventBus.Subscribe<PageLeftMoveDetected>(OnPageLeftMoveDetected);
        EventBus.Subscribe<PageRightMoveDetected>(OnPageRightMoveDetected);
        EventBus.Subscribe<HitGymDetected>(OnHitGymDetected);
        EventBus.Subscribe<InGameStartReady>(NowInGameStartReady);
        EventBus.Subscribe<InGym>(NowInGym);
        EventBus.Subscribe<InShop>(NowInShop);
    }

    private void NowInGym(InGym obj)
    {
        homePageUIManager.PlayerInGym();
    }

    private void NowInShop(InShop obj)
    {
        homePageUIManager.PlayerInShop();
    }

    private void NowInGameStartReady(InGameStartReady obj)
    {
        homePageUIManager.PlayerInReady();
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

    private void OnHitGymDetected(HitGymDetected obj)
    {
        Debug.Log("訓練");
    }

    private void OnHitShopDetected(HitShopDetected obj)
    {
        Debug.Log("商店");
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
