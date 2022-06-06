using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    #region Instance
    static public AnimatorManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    
    [Header("Other")] 
    [SerializeField] private Animator AN;

    
    // Start is called before the first frame update
    void Start()
    {
        AN = GetComponent<Animator>();
        /*
        if (ActorEnemy.GetEnemyBehaviour() == BehaviourEnum.EnemyBehaviour.isAttack)
        {
            
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerRightAttack()
    {
        AN.Play("Right_Attack");
    }
    
    public void PlayerLeftAttack()
    {
        AN.Play("Left_Attack");
    }

    public void PlayerDefend()
    {
        AN.Play("Attack_to_Def");
        AN.SetBool("Is_Attack_to_Def",false);
    }

    public void PlayerGetDefend()
    {
        AN.Play("Def_to_Attack");
    }

    public void PlayerDefendOver()
    {
        AN.SetBool("Is_Attack_to_Def",true);
    }
    
}
