using System.Collections;
using System.Collections.Generic;
using Project;
using Project.GamePlay;
using UnityEngine;

public class HPCalculation : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public int EnemyHP;
    [SerializeField] public int PlayerHP;
    [SerializeField] public int PlayerPower;
    [SerializeField] public int EnemyPower;
    [SerializeField] public int KillNumber;
    [SerializeField] public int WinNumber;
    [SerializeField] private float PlayerPowerCalculation;
    [SerializeField] private float EnemyPowerCalculation;
    [SerializeField] private float DamageFloat;

    public LVManager GetLV;
    private UIManager UICtrl;

    
    
    // Start is called before the first frame update
    void Start()
    {
        GetLV = GetComponent<LVManager>();
        UICtrl = GetComponent<UIManager>();
        
        GameStartNumber();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP <= 0)
        {
            EventBus.Post(new PlayerLoseDetected());
        }

        if (EnemyHP <= 0)
        {
            EventBus.Post(new EnemydeadDetected());
        }
        
        UICtrl.PlayerHPText(PlayerHP);
        UICtrl.EnemyHPText(EnemyHP);
        
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

    public void KillEnemy()
    {
        KillNumber++;
        EnemyHP = GetLV.GetEnemyHP;
    }

    private void GameStartNumber()
    {
        KillNumber = 0;
        WinNumber = GetLV.WinNeedNumber;
        PlayerHP = GetLV.GetPlayerHP;
        PlayerPower = GetLV.GetPlayerPower;
        EnemyHP = GetLV.GetEnemyHP;
        EnemyPower = GetLV.GetEnemyPower;
    }
}
