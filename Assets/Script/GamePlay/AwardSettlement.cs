using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardSettlement : MonoBehaviour
{
    private HPCalculation GetHP;

    [SerializeField] private float MoneyFlot;
    [SerializeField] private int GetMoney;
    [SerializeField] private int GameNowLV;
    [SerializeField] private int PlayerHaveMoney;

    // Start is called before the first frame update
    void Start()
    {
        GetHP = GetComponent<HPCalculation>();

        MoneyFlot = 500;
        
        GameOverSettlement();

        PlayerHaveMoney = PlayerPrefs.GetInt("PlayerMoney");
        GameNowLV = PlayerPrefs.GetInt("NowLV");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverSettlement()
    {
        for (int i = -5; i < GameNowLV; i++)
        {
            MoneyFlot = MoneyFlot * 1.5f;
            
        }
        MoneyFlot = MoneyFlot * GetHP.KillNumber;
        GetMoney = (int) MoneyFlot;
        PlayerHaveMoney = PlayerHaveMoney + GetMoney;
        PlayerPrefs.SetInt("TheSettlement",GetMoney);
        PlayerPrefs.SetInt("PlayerMoney",PlayerHaveMoney);
    }
}
