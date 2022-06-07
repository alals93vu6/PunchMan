using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Gym;
using UnityEngine;

public class GymLVManager : MonoBehaviour
{
    public GymUIManager GymUI;
    
    [SerializeField] public int PlayerLV;
    [SerializeField] public int PlayerMoney;
    [SerializeField] public int PlayerNeedMoney;
    [SerializeField] private float PlayerNeedMOneyFloat;
    [SerializeField] public int PlayerNeedTime;
    [SerializeField] private float PlayerNeedTimeFloat;
    
    [SerializeField] public bool LVUPing;
    
    // Start is called before the first frame update
    void Start()
    {
        GymUI = GetComponent<GymUIManager>();
        PlayerLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        PlayerMoney = PlayerPrefs.GetInt("PlayerMoney");
        PlayerNeedMoney = 3000;
        PlayerNeedMOneyFloat = PlayerNeedMoney;
        PlayerNeedTime = 40;
        PlayerNeedTimeFloat = PlayerNeedTime;

        LVUPing = false;
        
        NeedMoneySet();
        NeedTimeSet();
        GymUI.ReadyUP();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLVUPing();
    }

    public void NeedMoneySet()
    {
        for (int i = 1; i < PlayerLV ; i++)
        {
            PlayerNeedMOneyFloat = PlayerNeedMOneyFloat * 1.8f;
        }
        PlayerNeedMoney = (int) PlayerNeedMOneyFloat;
    }

    public void NeedTimeSet()
    {
        for (int i = 1; i < PlayerLV ; i++)
        {
            PlayerNeedTimeFloat = PlayerNeedTimeFloat * 1.2f;
        }
        PlayerNeedTime = (int) PlayerNeedTimeFloat;
    }

    public void PlayerLVUPing()
    {
        if (LVUPing)
        {
            PlayerNeedTimeFloat -= Time.deltaTime;
            PlayerNeedTime = (int) PlayerNeedTimeFloat;
            GymUI.MoneyChanges();
        }

        if (PlayerNeedMoney <= 0)
        {
            EventBus.Post(new PlayerLVUPDetected());
        }
    }

    public void LevelJudgment()
    {
        if (PlayerMoney >= PlayerNeedMoney)
        {
            EventBus.Post(new MoneyIsEnoughDetected());
            Debug.Log("AAB");
        }
        else
        {
            EventBus.Post(new MoneyIsNotEnoughDetected());
            Debug.Log("AAC");
        }
        Debug.Log("AAA");
    }

    public void PlayerLVIsUP()
    {
        LVUPing = false;
        PlayerLV++;
        PlayerPrefs.SetInt("NowPlayerLV",PlayerLV);
        NeedTimeSet();
    }

    public void NowCondition()
    {
        if (LVUPing)
        {
            EventBus.Post(new WatchADSDetected());
            
        }
        else
        {
            EventBus.Post(new HitLVUPButtonDetected());
            
        }
    }
}
