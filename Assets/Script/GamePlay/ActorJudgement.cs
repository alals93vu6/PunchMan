using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorJudgement : MonoBehaviour
{
    [SerializeField] private Actor actor;

    [SerializeField] private ActorEnemy actorEnemy;

    [Header("數值")] 
    [SerializeField] private int EnemyHP;
    [SerializeField] private int PlayerHP;
    [SerializeField] private float AttckTime;

    [Header("other")] 
    [SerializeField] private UIManager UICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 20;
        EnemyHP = 100;
        UICtrl = GetComponent<UIManager>();
    }

    void Update()
    {
        if (PlayerHP <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }

    public void PlayerJudge()
    {
        //Debug.Log("Start Juge");
        
        switch (actor.GetActorBehaviour())
        {
            case BehaviourEnum.ActorBehaviour.isDefend:
                if (actorEnemy.GetEnemyBehaviour() == BehaviourEnum.EnemyBehaviour.isAttack)
                {
                    PlayerGetDamage(1);
                    
                }

                break;
            
            case BehaviourEnum.ActorBehaviour.isLeftAttck:
                
                if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isAttack) //不是正在攻擊
                {
                    if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isLeftDefend) //不是正在左防禦
                    {
                        EnemyGetDamage(3); //打中
                        UICtrl.ShowText("你擊出左拳");
                        
                    }
                    else
                    {
                        EnemyGetDamage(1); //被防禦到了
                        UICtrl.ShowText("你擊出左拳");
                        
                    }
                }
                /*
                else //互尻
                {
                    PlayerGetDamage(8); 
                    EnemyGetDamage(2);
                    UICtrl.ShowText("你們互相攻擊");
                }
                */
                
                break;
            
            case BehaviourEnum.ActorBehaviour.isRightAttack:

                if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isAttack)
                {
                    if (actorEnemy.GetEnemyBehaviour() != BehaviourEnum.EnemyBehaviour.isRightDefend)
                    {
                        EnemyGetDamage(3);
                        UICtrl.ShowText("你擊出右拳");
                        
                    }
                    else
                    {
                        EnemyGetDamage(1);
                        UICtrl.ShowText("你擊出右拳");
                        
                    }
                }
                /*
                else
                {
                    PlayerGetDamage(8);
                    EnemyGetDamage(2);
                    UICtrl.ShowText("你們互相攻擊");
                }
                */
                break;
            
            case BehaviourEnum.ActorBehaviour.isIdle:
                break;
        }
        
        UICtrl.PlayerHPText(PlayerHP);
        UICtrl.EnemyHPText(EnemyHP);
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
        
        UICtrl.PlayerHPText(PlayerHP);
        UICtrl.EnemyHPText(EnemyHP);
        
    }

    private void EnemyAttck()
    {
        if (actor.GetActorBehaviour() == BehaviourEnum.ActorBehaviour.isDefend)
        {
            PlayerGetDamage(1);
            UICtrl.ShowText("你防禦住了");
            
            Debug.Log("ATKC");
            
            actorEnemy.ResetBehaviour();
        }
        else
        {
            if (actor.GetActorBehaviour() == BehaviourEnum.ActorBehaviour.isIdle)
            {
                PlayerGetDamage(5);
                UICtrl.ShowText("你被擊中了");
                
                Debug.Log("ATKB");
                
                actorEnemy.ResetBehaviour();
            }
            else
            {
                PlayerGetDamage(8);
                EnemyGetDamage(2);
                UICtrl.ShowText("你們互相攻擊");
                
                Debug.Log("ATKA");
                
                actorEnemy.ResetBehaviour();
            }
        }
        
    }

    private void PlayerGetDamage(int damage)
    {
        PlayerHP -= damage;
    }
    
    private void EnemyGetDamage(int damage)
    {
        EnemyHP -= damage;
    }
    
    
}
