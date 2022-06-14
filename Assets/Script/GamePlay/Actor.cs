using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [Header("狀態")]

    [SerializeField] private bool WaitTime;
    [SerializeField] private bool PlayerIsLeft;
    [SerializeField] private bool PlayerIsRight;
    [SerializeField] private bool IsDefend;

    [SerializeField] private BehaviourEnum.ActorBehaviour actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;

    [Header("數值")]
    [SerializeField] private float ButtonTime , ButtonTimeMax;
    //[SerializeField] private float DfTime;

    [Header("其他")] 
    [SerializeField] private UIManager UICtrl;
    [SerializeField] private ActorJudgement actorJudgement;

        // Start is called before the first frame update
    void Start()
    {
        //DfTime = 5;
        UICtrl = GetComponent<UIManager>();
    }

    // Update is called once per frame


    /*
    public IEnumerator ActorBehaviourJudge(BehaviourEnum.ActorBehaviour _actor)
    {
        //TODO
        
        
        ButtonTime += 0.1f;

        if (ButtonTime <= ButtonTimeMax)
        {
            if (_actor != actorBehaviour)
            {
                actorBehaviour = BehaviourEnum.ActorBehaviour.isDefend;
                //Debug.Log("Defend");
                actorJudgement.PlayerJudge();
                
                WaitTime = false;
                //actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;
                yield return null;
            }
            
            yield return new WaitForSeconds(0.1f);
            //Debug.Log(_actor);
            StartCoroutine(ActorBehaviourJudge(_actor));
        }
        else
        {
            actorJudgement.PlayerJudge();
            
            WaitTime = false;
            actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;
            yield return null;
        }

    }
    */

    public void DefendButtonJudge()
    {
        if (PlayerIsLeft && PlayerIsRight)
        {
            actorBehaviour = BehaviourEnum.ActorBehaviour.isDefend;
            actorJudgement.PlayerJudge();
            AnimatorManager.instance.PlayerDefend();
            IsDefend = true;
            Invoke("DefendOFF",3f);
        }
        else if (!PlayerIsLeft && PlayerIsRight)
        {
            actorBehaviour = BehaviourEnum.ActorBehaviour.isRightAttack;
            actorJudgement.PlayerJudge();
            actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;
            
        }
        else if (PlayerIsLeft && !PlayerIsRight)
        {
            actorBehaviour = BehaviourEnum.ActorBehaviour.isLeftAttck;
            actorJudgement.PlayerJudge();
            actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;
        }

        PlayerIsLeft = false;
        PlayerIsRight = false;
    }

    public void GetLeftButton()
    {
        if (!IsDefend)
        {
            PlayerIsLeft = true;
            Invoke("DefendButtonJudge",0.6f);
        }
        
        
        /*
        actorBehaviour = BehaviourEnum.ActorBehaviour.isLeftAttck;
        
        if (!WaitTime && PlayerIsLeft)
        {
            ButtonTime = 0f;
            WaitTime = true;
            

            StartCoroutine(ActorBehaviourJudge(actorBehaviour));
        }
        */
    }
    public void GetRightButton()
    {
        if (!IsDefend)
        {
            PlayerIsRight = true;
            Invoke("DefendButtonJudge",0.6f);
        }

        /*
        actorBehaviour = BehaviourEnum.ActorBehaviour.isRightAttack;
        
        if (!WaitTime && PlayerIsRight)
        {
            ButtonTime = 0f;
            WaitTime = true;
            

            StartCoroutine(ActorBehaviourJudge(actorBehaviour));
        }
        */
    }

    public void DefendOFF()
    {
        IsDefend = false;
        AnimatorManager.instance.PlayerDefendOver();
        actorBehaviour = BehaviourEnum.ActorBehaviour.isIdle;
    }

    private void BehaviorDetected()
    {
        
        
        
        /*
        
        if(GetLeft == false && GetRight == true)
        {
            UICtrl.ShowText("您擊出右拳");
            ScoreCtrl.PlayerATK(false);
            GetRight = false;
        }

        if(GetLeft == true && GetRight == false)
        {
            UICtrl.ShowText("您擊出左拳");
            ScoreCtrl.PlayerATK(true);
            GetLeft = false;
        }
        
        WaitTime = false;
        
        */
    }

    public void IsHit()
    {
        
        /*
        DfTime = 5f;
        IsDF = false;
        UICtrl.ShowText("您已擋下攻擊");
        
        */
    }

    public BehaviourEnum.ActorBehaviour GetActorBehaviour()
    {
        return actorBehaviour;
    }

}
