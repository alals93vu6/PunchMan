using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorManager : MonoBehaviour
{
    #region Instance
    static public EnemyAnimatorManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    
    [Header("Other")] 
    [SerializeField] private Animator EnemyAN;

    
    // Start is called before the first frame update
    void Start()
    {
        EnemyAN = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyIsAttack()
    {
        EnemyAN.Play("Attack_Standby");
        EnemyAN.SetBool("Is_Defend_R",false);
        EnemyAN.SetBool("Is_Defend_L",false);
    }
    
    public void EnemyIsLDF()
    {
        //EnemyAN.Play("Def_Left");
        EnemyAN.SetBool("Is_Defend_L",true);
        EnemyAN.SetBool("Is_Defend_R",false);
    }
    
    public void EnemyIsRDF()
    {
        //EnemyAN.Play("Def_Right");
        EnemyAN.SetBool("Is_Defend_R",true);
        EnemyAN.SetBool("Is_Defend_L",false);
    }
}
