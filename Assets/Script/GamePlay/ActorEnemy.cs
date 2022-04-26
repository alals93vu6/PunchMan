using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorEnemy : MonoBehaviour
{
    [SerializeField] private BehaviourEnum.EnemyBehaviour actorBehaviour = BehaviourEnum.EnemyBehaviour.isAttack;

    [SerializeField] private ActorJudgement actorJudgement;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BehaviourLoop" , 0 , 6);
        InvokeRepeating("Judgement",0,6);
        actorJudgement = GetComponent<ActorJudgement>();
    }

    public void BehaviourLoop()
    {
        int BehaviourID = Random.Range(0 , 3);

        switch (BehaviourID)
        {
            case 0:
                actorBehaviour = BehaviourEnum.EnemyBehaviour.isAttack;
                UIManager.instacne.isAttck();
                break;
            
            case 1:
                actorBehaviour = BehaviourEnum.EnemyBehaviour.isLeftDefend;
                UIManager.instacne.isLeftDF();
                break;
            
            case 2:
                actorBehaviour = BehaviourEnum.EnemyBehaviour.isRightDefend;
                UIManager.instacne.isRightDF();
                break;
            
            default:
                //Debug.Log("ERROR ID");
                break;
        }

        //Debug.Log(actorBehaviour);
        
    }

    public void ResetBehaviour()
    {
        CancelInvoke();
        InvokeRepeating("BehaviourLoop" , 0 , 6);
        InvokeRepeating("Judgement",0,6);
    }
    
    

    private void Judgement()
    {
        actorJudgement.EnemyJudge();
    }

    public BehaviourEnum.EnemyBehaviour GetEnemyBehaviour()
    {
        return actorBehaviour;
    }
}
