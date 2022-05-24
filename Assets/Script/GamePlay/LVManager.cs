using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVManager : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public float EnemyHPLV;
    [SerializeField] public float PlayerHPLV;
    [SerializeField] public float PlayerPowerLV;
    [SerializeField] public float EnemyPowerLV;
    [SerializeField] public int NowLV;
    [SerializeField] public int NowHPLV;
    [SerializeField] public int NowPowerLV;
    [SerializeField] public int GetEnemyHP;
    [SerializeField] public int GetPlayerHP;
    [SerializeField] public int GetPlayerPower;
    [SerializeField] public int GetEnemyPower;
    [SerializeField] public int WinNeedNumber;

    private UIManager UICtrl;
    
    // Start is called before the first frame update

    void Awake()
    {
        UICtrl = GetComponent<UIManager>();
        PlayerHPLV = 20;
        PlayerPowerLV = 3;
        EnemyHPLV = 30;
        EnemyPowerLV = 5;

        NowLV = PlayerPrefs.GetInt("NowGameLV");
        NowHPLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        NowPowerLV = PlayerPrefs.GetInt("NowPlayerPowerLV");
        
        FirstGamePlay();

        WinNeedNumber = 3 * NowLV - 1 * (NowLV - 1);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerHPSet(int FinalPlayerHP)
    {
        for (int iA = 0; iA < NowHPLV; iA++)
        {
            PlayerHPLV = PlayerHPLV * 1.5f;
            GetPlayerHP = (int)PlayerHPLV;
            FinalPlayerHP = GetPlayerHP;
        }
    }

    public void PlayerPowerSet(int FinalPlayerPower)
    {
        for (int iB = 0; iB < NowPowerLV; iB++)
        {
            PlayerPowerLV = PlayerPowerLV * 1.5f;
            GetPlayerPower = (int)PlayerPowerLV;
            FinalPlayerPower = GetPlayerPower;
        }
    }

    public void EnemyHPSet(int FinalEnemyHP)
    {
        for (int iC = 1; iC < NowLV; iC++)
        {
            EnemyHPLV = EnemyHPLV * 1.8f;
            GetEnemyHP = (int)EnemyHPLV;
            FinalEnemyHP = GetEnemyHP;
            
        }
    }

    public void EnemyPowerSet(int FinalEnemyPower)
    {
        for (int iD = 1; iD < NowLV; iD++)
        {
            EnemyPowerLV = EnemyPowerLV * 1.75f;
            GetEnemyPower = (int)EnemyPowerLV;
            FinalEnemyPower = GetEnemyPower;
        }
    }
    
    

    private void FirstGamePlay()
    {
        if (NowLV <= 0)
        {
            NowLV = 1;
            PlayerPrefs.SetInt("NowGameLV",1);
        }
    }
}
