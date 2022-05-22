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

    private UIManager UICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        UICtrl = GetComponent<UIManager>();
        PlayerHPLV = 20;
        PlayerPowerLV = 3;
        EnemyHPLV = 30;
        EnemyPowerLV = 5;
        
        NowLV = PlayerPrefs.GetInt("NowGameLV");
        NowHPLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        NowPowerLV = PlayerPrefs.GetInt("NowPlayerPowerLV");
        
        PlayerHPSet();
        PlayerPowerSet();
        EnemyHPSet();
        EnemyPowerSet();

        GetEnemyHP = (int) EnemyHPLV;
        GetPlayerHP = (int) PlayerHPLV;
        GetPlayerPower = (int) PlayerPowerLV;
        GetEnemyPower = (int) EnemyPowerLV;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerHPSet()
    {
        for (int iA = 0; iA < NowHPLV; iA++)
        {
            PlayerHPLV = PlayerHPLV * 1.5f;
        }
    }

    private void PlayerPowerSet()
    {
        for (int iB = 0; iB < NowPowerLV; iB++)
        {
            PlayerPowerLV = PlayerPowerLV * 1.5f;
        }
    }

    private void EnemyHPSet()
    {
        for (int iC = 0; iC < NowLV; iC++)
        {
            EnemyHPLV = EnemyHPLV * 1.8f;
        }
    }

    private void EnemyPowerSet()
    {
        for (int iD = 0; iD < NowLV; iD++)
        {
            EnemyPowerLV = EnemyPowerLV * 1.75f;
        }
    }
}
