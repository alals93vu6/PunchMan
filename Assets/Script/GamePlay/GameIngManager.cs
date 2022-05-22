using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.GamePlay;
using UnityEngine;

public class GameIngManager : MonoBehaviour
{
    private HPCalculation HpCorrection;
    private UIManager UICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        HpCorrection = GetComponent<HPCalculation>();
        UICtrl = GetComponent<UIManager>();
        
        
        EventBus.Subscribe<PlayerAndEnemyMutualAttckDetected>(OnPlayerMutualAttack); //互相攻擊
        
        EventBus.Subscribe<PlayerDefendAttackDetected>(OnPlayerDefend); //玩家防禦成功 isDefend == false ；； isDefend == true
        EventBus.Subscribe<PlayerGetAttackDetected>(OnPlayerGetHit); //玩家被攻擊
        
        EventBus.Subscribe<PlayerAttackDefendDetected>(OnPlayerNotHitEnemy); //玩家攻擊被對方防禦
        EventBus.Subscribe<PlayerAttackHitDetected>(OnPlayerHitEnemy); //玩家打中
    }

    private void OnPlayerDefend(PlayerDefendAttackDetected obj)
    {
        HpCorrection.PlayerGetDamage(0.2f);
        UICtrl.ShowText("你防禦住了");
        Debug.Log("ATKC");
    }

    private void OnPlayerGetHit(PlayerGetAttackDetected obj)
    {
        HpCorrection.PlayerGetDamage(1f);
        UICtrl.ShowText("你被擊中了");
        Debug.Log("ATKB");
    }

    private void OnPlayerHitEnemy(PlayerAttackHitDetected obj)
    {
        HpCorrection.EnemyGetDamage(1f);
    }

    private void OnPlayerNotHitEnemy(PlayerAttackDefendDetected obj)
    {
        HpCorrection.EnemyGetDamage(0.4f);
    }

    private void OnPlayerMutualAttack(PlayerAndEnemyMutualAttckDetected obj)
    {
        HpCorrection.PlayerGetDamage(1.5f);
        HpCorrection.EnemyGetDamage(1f);
        UICtrl.ShowText("你們互相攻擊");
    }

    private void OnPlayerLATK()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
