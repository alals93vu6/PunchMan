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
}
