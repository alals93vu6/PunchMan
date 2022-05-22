using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCalculation : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public int EnemyHP;
    [SerializeField] public int PlayerHP;
    [SerializeField] public int PlayerPower;
    [SerializeField] public int EnemyPower;
    [SerializeField] private float PlayerPowerCalculation;
    [SerializeField] private float EnemyPowerCalculation;
    [SerializeField] private float DamageFloat;

    public LVManager GetLV;

    
    
    // Start is called before the first frame update
    void Start()
    {
        GetLV = GetComponent<LVManager>();
        PlayerHP = GetLV.GetPlayerHP;
        PlayerPower = GetLV.GetPlayerPower;
        EnemyHP = GetLV.GetEnemyHP;
        EnemyPower = GetLV.GetEnemyPower;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
    }
    
    
    
    public void PlayerGetDamage(float damage)
    {
        EnemyPowerCalculation = EnemyPower;
        DamageFloat = EnemyPowerCalculation * damage;
        
        PlayerHP -= (int) DamageFloat;
    }
    
    public void EnemyGetDamage(float damage)
    {
        PlayerPowerCalculation = PlayerPower;
        DamageFloat = PlayerPowerCalculation * damage;

        EnemyHP -=  (int) DamageFloat;
    }
}
