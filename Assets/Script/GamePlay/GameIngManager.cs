using System;
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
    }

    private void OnEnemyDead(EnemydeadDetected obj)
    {
        if (hpCorrection.KillNumber >= hpCorrection.WinNumber -1)
        {
            lvManager.PlayerWin();
            GameOverSet.GameOverSettlement();
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    private void OnPlayerWin(PlayerWinDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    private void OnPlayerDefend(PlayerDefendAttackDetected obj)
    {
        hpCorrection.PlayerGetDamage(0.2f);
        UICtrl.ShowText("你防禦住了");
        Debug.Log("ATKC");
    }

    private void OnPlayerGetHit(PlayerGetAttackDetected obj)
    {
        hpCorrection.PlayerGetDamage(1f);
        UICtrl.ShowText("你被擊中了");
        Debug.Log("ATKB");
    }

    private void OnPlayerHitEnemy(PlayerAttackHitDetected obj)
    {
        hpCorrection.EnemyGetDamage(1f);
    }

    private void OnPlayerNotHitEnemy(PlayerAttackDefendDetected obj)
    {
        hpCorrection.EnemyGetDamage(0.4f);
    }

    private void OnPlayerMutualAttack(PlayerAndEnemyMutualAttckDetected obj)
    {
        hpCorrection.PlayerGetDamage(1.5f);
        hpCorrection.EnemyGetDamage(1f);
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
