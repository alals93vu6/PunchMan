using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [Header("物件")]
    [SerializeField] GameObject Enemy;

    [Header("Other")] 
    [SerializeField] private Animator AN;

    [SerializeField] private ActorEnemy ActorEnemy;
    
    // Start is called before the first frame update
    void Start()
    {
        AN = GetComponent<Animator>();

        if (ActorEnemy.GetEnemyBehaviour() == BehaviourEnum.EnemyBehaviour.isAttack)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
