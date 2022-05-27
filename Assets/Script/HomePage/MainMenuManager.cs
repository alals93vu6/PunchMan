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
        EventBus.Subscribe<GameStartDetected>(OnGameStartDetected); //遊戲開始
        EventBus.Subscribe<QuitGameDetected>(OnQuitGameDetected); //關閉遊戲
        EventBus.Subscribe<HitShopDetected>(OnHitShopDetected); //點擊商城
        EventBus.Subscribe<PageLeftMoveDetected>(OnPageLeftMoveDetected); //視角左移
        EventBus.Subscribe<PageRightMoveDetected>(OnPageRightMoveDetected); //視角右移
        EventBus.Subscribe<HitGymDetected>(OnHitGymDetected); // 點及健身房
        EventBus.Subscribe<InGameStartReady>(NowInGameStartReady); //開始遊戲介面
        EventBus.Subscribe<InGym>(NowInGym); //強化介面
        EventBus.Subscribe<InShop>(NowInShop); //商城介面
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gym");
    }

    private void OnHitShopDetected(HitShopDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Shop");
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
