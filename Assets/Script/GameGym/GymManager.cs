using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Gym;
using UnityEngine;
using BackHomePageDetected = Project.Shop.BackHomePageDetected;

public class GymManager : MonoBehaviour
{
    public GymLVManager GetGymLV;
    public GymUIManager GymUICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        GetGymLV = GetComponent<GymLVManager>();
        GymUICtrl = GetComponent<GymUIManager>();
        
        EventBus.Subscribe<HitLVUPButtonDetected>(OnLvUP);//點擊升級按鈕
        EventBus.Subscribe<WatchADSDetected>(OnWatchADS);//看廣告
        EventBus.Subscribe<PlayerLVUPDetected>(OnPlayerLVUP);//升等
        EventBus.Subscribe<MoneyIsEnoughDetected>(OnReadyLVUP);//錢足夠
        EventBus.Subscribe<MoneyIsNotEnoughDetected>(CantLVUP);//錢不夠
        EventBus.Subscribe<BackHomePageDetected>(OnBackHomePage);//返回主頁
        EventBus.Subscribe<HitGymButtonDetected>(OnConditionJudgment);//按下按鈕
    }

    private void OnConditionJudgment(HitGymButtonDetected obj)
    {
        GetGymLV.NowCondition();
    }

    private void OnBackHomePage(BackHomePageDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }

    private void OnReadyLVUP(MoneyIsEnoughDetected obj)
    {
        GetGymLV.UPNeedMoney();
        GymUICtrl.UPing();
        GetGymLV.LVUPing = true;
    }

    private void CantLVUP(MoneyIsNotEnoughDetected obj)
    {
        GymUICtrl.EnoughMoney();
    }

    private void OnPlayerLVUP(PlayerLVUPDetected obj)
    {
        GetGymLV.PlayerLVIsUP();
        GymUICtrl.ReadyUP();
    }

    private void OnWatchADS(WatchADSDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("ADsB");
    }

    private void OnLvUP(HitLVUPButtonDetected obj)
    {
        GetGymLV.LevelJudgment();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
