using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopGetLVManager : MonoBehaviour
{

    [Header("現在等級")]
    [SerializeField] private int GlovesALV;
    [SerializeField] private int GlovesBLV;
    [SerializeField] private int GlovesCLV;
    [SerializeField] private int GlovesDLV;
    [SerializeField] private int GlovesELV;

    [Header("需要金額")] 
    [SerializeField] private float ANeedMoneyFloat;
    [SerializeField] private float BNeedMoneyFloat;
    [SerializeField] private float CNeedMoneyFloat;
    [SerializeField] private float DNeedMoneyFloat;
    [SerializeField] private float ENeedMoneyFloat;
    [SerializeField] private int AshowMoney;
    [SerializeField] private int BshowMoney;
    [SerializeField] private int CshowMoney;
    [SerializeField] private int DshowMoney;
    [SerializeField] private int EshowMoney;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GameStartGetNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GameStartGetNumber()
    {
        GetNowGlovesLV();
        FloatSet();
        GetAllNeedMoney();
    }

    private void GetNowGlovesLV()
    {
        GlovesALV = PlayerPrefs.GetInt("NowGlovesALV");
        GlovesBLV = PlayerPrefs.GetInt("NowGlovesBLV");
        GlovesCLV = PlayerPrefs.GetInt("NowGlovesCLV");
        GlovesDLV = PlayerPrefs.GetInt("NowGlovesDLV");
        GlovesELV = PlayerPrefs.GetInt("NowGlovesELV");
    }

    public void GetAllNeedMoney()
    {
        GlovesANeedMoney();
        GlovesBNeedMoney();
        GlovesCNeedMoney();
        GlovesDNeedMoney();
        GlovesENeedMoney();
    }

    private void FloatSet()
    {
        ANeedMoneyFloat = 1500;
        BNeedMoneyFloat = 1500;
        CNeedMoneyFloat = 1500;
        DNeedMoneyFloat = 1500;
        ENeedMoneyFloat = 1500;
    }

    private void GlovesANeedMoney()
    {
        for (int i = 0; i < GlovesALV; i++)
        {
            ANeedMoneyFloat = ANeedMoneyFloat * 1.5f;
        }

        AshowMoney = (int)ANeedMoneyFloat;
    }
    
    private void GlovesBNeedMoney()
    {
        for (int i = 0; i < GlovesBLV; i++)
        {
            BNeedMoneyFloat = BNeedMoneyFloat * 1.5f;
        }

        BshowMoney = (int)BNeedMoneyFloat;
    }
    
    private void GlovesCNeedMoney()
    {
        for (int i = 0; i < GlovesCLV; i++)
        {
            CNeedMoneyFloat = CNeedMoneyFloat * 1.5f;
        }

        CshowMoney = (int)CNeedMoneyFloat;
    }
    
    private void GlovesDNeedMoney()
    {
        for (int i = 0; i < GlovesDLV; i++)
        {
            DNeedMoneyFloat = DNeedMoneyFloat * 1.5f;
        }

        DshowMoney = (int)DNeedMoneyFloat;
    }
    
    private void GlovesENeedMoney()
    {
        for (int i = 0; i < GlovesELV; i++)
        {
            ENeedMoneyFloat = ENeedMoneyFloat * 1.5f;
        }

        EshowMoney = (int)ENeedMoneyFloat;
    }
}
