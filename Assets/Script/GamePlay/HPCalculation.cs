using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCalculation : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public int EnemyHP;
    [SerializeField] public int PlayerHP;
    [SerializeField] private float AttckTime;

    
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 20;
        EnemyHP = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
    
    
    
    public void PlayerGetDamage(int damage)
    {
        PlayerHP -= damage;
    }
    
    public void EnemyGetDamage(int damage)
    {
        EnemyHP -= damage;
    }
}
