using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.GamePlay;
using UnityEngine;

public class ActorJudgement : MonoBehaviour
{
    [SerializeField] private Actor actor;

    [SerializeField] private ActorEnemy actorEnemy;

    [Header("other")] 
    [SerializeField] private UIManager UICtrl;

    [SerializeField] private HPCalculation HPFlot;
    
    // Start is called before the first frame update
    void Start()
    {
        UICtrl = GetComponent<UIManager>();
        HPFlot = GetComponent<HPCalculation>();
        UICtrl.PlayerHPText(HPFlot.PlayerHP);
        UICtrl.EnemyHPText(HPFlot.EnemyHP);
    }

    void Update()
    {
        
    }

    public void PlayerJudge()
    {
        //Debug.Log("Start Juge");
        
        switch (actor.GetActorBehaviour())
        {
            case BehaviourEnum.ActorBehaviour.isDefend:
                if (actorEnemy.GetEnemyBehaviour() == BehaviourEnum.EnemyBehaviour.isAttack)
                {
                    //PlayerGetDamage(1);
                    EventBus.Post(new PlayerDefendAttackDetected());
                }

                break;
            
            case BehaviourEnum.ActorBehaviour.isLeftAttck:
                
                if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isAttack) //不是正在攻擊
                {
                    if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isLeftDefend) //不是正在左防禦
                    {
                        //EnemyGetDamage(3); //打中
                        EventBus.Post(new PlayerAttackHitDetected());
                        UICtrl.ShowText("你擊出左拳");
                        
                    }
                    else
                    {
                        //EnemyGetDamage(1); //被防禦到了
                        EventBus.Post(new PlayerAttackDefendDetected());
                        UICtrl.ShowText("你擊出左拳");
                        
                    }
                }
                else //互尻
                {
                    //PlayerGetDamage(8); 
                    //EnemyGetDamage(2);
                    //EventBus.Post(new PlayerAndEnemyMutualAttckDetected());
                    
                }
                
                
                break;
            
            case BehaviourEnum.ActorBehaviour.isRightAttack:

                if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isAttack)
                {
                    if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isRightDefend)
                    {
                        //EnemyGetDamage(3);
                        EventBus.Post(new PlayerAttackHitDetected());
                        UICtrl.ShowText("你擊出右拳");
                        
                    }
                    else
                    {
                        //EnemyGetDamage(1);
                        EventBus.Post(new PlayerAttackDefendDetected());
                        UICtrl.ShowText("你擊出右拳");
                        
                    }
                }
                else
                {
                    //PlayerGetDamage(8);
                    //EnemyGetDamage(2);
                    //EventBus.Post(new PlayerAndEnemyMutualAttckDetected());
                    
                }
                
                break;
            
            case BehaviourEnum.ActorBehaviour.isIdle:
                
                
                break;
        }
        
        UICtrl.PlayerHPText(HPFlot.PlayerHP);
        UICtrl.EnemyHPText(HPFlot.EnemyHP);
        actorEnemy.ResetBehaviour();
    }

    public void EnemyJudge()
    {
        switch (actorEnemy.GetEnemyBehaviour())
        {
            case BehaviourEnum.EnemyBehaviour.isAttack:
                
                UICtrl.ShowText("敵人準備攻擊");
                Invoke("EnemyAttck",2f);
                    
                break;
        }
    }

    private void EnemyAttck()
    {
        if (actor.GetActorBehaviour() == BehaviourEnum.ActorBehaviour.isDefend)
        {
            //PlayerGetDamage(1);
            EventBus.Post(new PlayerDefendAttackDetected());
            
            
            
            
            actorEnemy.ResetBehaviour();
        }
        else
        {
            if (actor.GetActorBehaviour() == BehaviourEnum.ActorBehaviour.isIdle)
            {
                //PlayerGetDamage(5);
                EventBus.Post(new PlayerGetAttackDetected());
                
                
                
                
                actorEnemy.ResetBehaviour();
            }
            else
            {
                //PlayerGetDamage(8);
                //EnemyGetDamage(2);
                
                EventBus.Post(new PlayerAndEnemyMutualAttckDetected());

                actorEnemy.ResetBehaviour();
            }
            
        }
        
        CancelInvoke("EnemyAttck");
        UICtrl.PlayerHPText(HPFlot.PlayerHP);
        UICtrl.EnemyHPText(HPFlot.EnemyHP);
    }

    
    
    
}
