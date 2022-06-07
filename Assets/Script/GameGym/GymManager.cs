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
        
        EventBus.Subscribe<HitLVUPButtonDetected>(OnLvUP);
        EventBus.Subscribe<WatchADSDetected>(OnWatchADS);
        EventBus.Subscribe<PlayerLVUPDetected>(OnPlayerLVUP);
        EventBus.Subscribe<MoneyIsEnoughDetected>(OnReadyLVUP);
        EventBus.Subscribe<MoneyIsNotEnoughDetected>(CantLVUP);
        EventBus.Subscribe<BackHomePageDetected>(OnBackHomePage);
    }

    private void OnBackHomePage(BackHomePageDetected obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnReadyLVUP(MoneyIsEnoughDetected obj)
    {
        GymUICtrl.UPing();
        GetGymLV.LVUPing = true;
    }

    private void CantLVUP(MoneyIsNotEnoughDetected obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnPlayerLVUP(PlayerLVUPDetected obj)
    {
        GetGymLV.PlayerLVIsUP();
        GymUICtrl.ReadyUP();
    }

    private void OnWatchADS(WatchADSDetected obj)
    {
        throw new System.NotImplementedException();
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
