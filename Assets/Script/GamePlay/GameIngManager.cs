﻿using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.GamePlay;
using UnityEngine;

public class GameIngManager : MonoBehaviour
{
    private HPCalculation hpCorrection;
    private UIManager UICtrl;
    private LVManager lvManager;
    private AwardSettlement GameOverSet;
    
    // Start is called before the first frame update
    void Start()
    {
        hpCorrection = GetComponent<HPCalculation>();
        UICtrl = GetComponent<UIManager>();
        lvManager = GetComponent<LVManager>();
        GameOverSet = GetComponent<AwardSettlement>();
        
        EventBus.Subscribe<PlayerAndEnemyMutualAttckDetected>(OnPlayerMutualAttack); //互相攻擊
        
        EventBus.Subscribe<PlayerDefendAttackDetected>(OnPlayerDefend); //玩家防禦成功 isDefend == false ；； isDefend == true
        EventBus.Subscribe<PlayerGetAttackDetected>(OnPlayerGetHit); //玩家被攻擊
        
        EventBus.Subscribe<PlayerAttackDefendDetected>(OnPlayerNotHitEnemy); //玩家攻擊被對方防禦
        EventBus.Subscribe<PlayerAttackHitDetected>(OnPlayerHitEnemy); //玩家打中
        
        EventBus.Subscribe<EnemydeadDetected>(OnEnemyDead);
        
        EventBus.Subscribe<PlayerWinDetected>(OnPlayerWin); //玩家勝利
        EventBus.Subscribe<PlayerLoseDetected>(OnPlayerLose); //玩家失敗
        EventBus.Subscribe<CloseADS>(OnCloseADS);
    }

    private void OnCloseADS(CloseADS obj)
    {
        UICtrl.ShowSettementUI();
    }

    private void OnEnemyDead(EnemydeadDetected obj)
    {
        if (hpCorrection.KillNumber >= hpCorrection.WinNumber)
        {
            lvManager.PlayerWin();
            GameOverSet.GameOverSettlement();
            UICtrl.ShowADSUI();
        }
        else
        {
            UICtrl.ShowText("擊殺一名敵人");
            hpCorrection.KillEnemy();
        }
    }

    private void OnPlayerLose(PlayerLoseDetected obj)
    {
        GameOverSet.GameOverSettlement();
        UICtrl.ShowADSUI();
        //Debug.Log("BBB");
    }

    private void OnPlayerWin(PlayerWinDetected obj)
    {
        GameOverSet.GameOverSettlement();
        UICtrl.ShowADSUI();
        lvManager.PlayerWin();
    }

    private void OnPlayerDefend(PlayerDefendAttackDetected obj)
    {
        hpCorrection.PlayerGetDamage(0.2f);
        hpCorrection.HPCUpDeta();
        UICtrl.ShowText("你防禦住了");
        //Debug.Log("ATKC");
    }

    private void OnPlayerGetHit(PlayerGetAttackDetected obj)
    {
        hpCorrection.PlayerGetDamage(1f);
        hpCorrection.HPCUpDeta();
        UICtrl.ShowText("你被擊中了");
        //Debug.Log("ATKB");
    }

    private void OnPlayerHitEnemy(PlayerAttackHitDetected obj)
    {
        hpCorrection.EnemyGetDamage(1f);
        hpCorrection.HPCUpDeta();
    }

    private void OnPlayerNotHitEnemy(PlayerAttackDefendDetected obj)
    {
        hpCorrection.EnemyGetDamage(0.4f);
        hpCorrection.HPCUpDeta();
    }

    private void OnPlayerMutualAttack(PlayerAndEnemyMutualAttckDetected obj)
    {
        hpCorrection.PlayerGetDamage(1.5f);
        hpCorrection.EnemyGetDamage(1f);
        hpCorrection.HPCUpDeta();
        //UICtrl.ShowText("你們互相攻擊");
    }
    

    // Update is called once per frame
    
}
