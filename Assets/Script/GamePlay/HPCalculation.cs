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

    public bool IsPlaying;
    
    public LVManager GetLV;
    private UIManager UICtrl;
    public ActorEnemy EnemyCtrl;

    
    
    // Start is called before the first frame update
    void Start()
    {
        GetLV = GetComponent<LVManager>();
        UICtrl = GetComponent<UIManager>();
        EnemyCtrl = GetComponent<ActorEnemy>();

        IsPlaying = true;
        
        GameStartNumber();
        HPCUpDeta();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        UICtrl.PlayerHPText(PlayerHP);
        UICtrl.EnemyHPText(EnemyHP);
    }

    public void PlayerGetDamage(float damage)
    {
        if (IsPlaying)
        {
            EnemyPowerCalculation = EnemyPower;
            DamageFloat = EnemyPowerCalculation * damage;
                                
            PlayerHP -= (int) DamageFloat;
        }
    }
    
    public void EnemyGetDamage(float damage)
    {
        if (IsPlaying)
        {
            PlayerPowerCalculation = PlayerPower;
            DamageFloat = PlayerPowerCalculation * damage;
                        
            EnemyHP -=  (int) DamageFloat;
        }
    }

    public void KillEnemy()
    {
        KillNumber++;
        EnemyHP = GetLV.GetEnemyHP;
    }

    public void HPCUpDeta()
    {
        if (PlayerHP <= 0 && IsPlaying)
        {
            EventBus.Post(new PlayerLoseDetected());
            EnemyCtrl.IsOver = true;
            IsPlaying = false;
        }
        
        if (EnemyHP <= 0)
        {
            EventBus.Post(new EnemydeadDetected());
        }
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
