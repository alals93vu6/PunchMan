using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Instance<UIManager>
{
    [Header("遊戲中")] 
    [SerializeField] public GameObject PlayingUI;
    [SerializeField] private Text UItext;
    [SerializeField] private Text EnemyHP;
    [SerializeField] private Text PlayerHP;

    [Header("結算")] 
    [SerializeField] public GameObject SettlementUI;
    [SerializeField] private Text GetMoney;
    [SerializeField] private Text AllMoney;
    
    [Header("ADS")] 
    [SerializeField] private float ADSTime;
    [SerializeField] public GameObject ADSUI;
    [SerializeField] public GameObject ADSButton;
    [SerializeField] private bool PlayADS;


    // Start is called before the first frame update
    void Start()
    {
        GameStart();
        PlayADS = false;
        ADSButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayADS)
        {
            ADSTime += Time.deltaTime;
        }

        if (ADSTime >= 5)
        {
            ADSButton.SetActive(true);
        }
    }

    public void ShowGetMoney(int NowGetMoney)
    {
        GetMoney.text = "這場獲得的金幣：" + NowGetMoney;
    }

    public void ShowAllMoney(int NowAllMoney)
    {
        AllMoney.text = "目前擁有的金錢：" + NowAllMoney;
    }

    public void ShowText(string textA)
    {
        UItext.text = textA;
    }

    public void EnemyHPText(int NowHP)
    {
        EnemyHP.text = "敵人血量：" + NowHP;
    }
    
    public void PlayerHPText(int NowHP)
    {
        PlayerHP.text = "玩家血量：" + NowHP;
    }

    private void GameStart()
    {
        ShowText("無動作");
        EnemyHPText(999);
    }

    public void ShowGamePlayingUI()
    {
        PlayingUI.SetActive(true);
        SettlementUI.SetActive(false);
        ADSUI.SetActive(false);
    }

    public void ShowADSUI()
    {
        PlayingUI.SetActive(false);
        SettlementUI.SetActive(false);
        ADSUI.SetActive(true);
        PlayADS = true;
    }

    public void ShowSettementUI()
    {
        PlayingUI.SetActive(false);
        SettlementUI.SetActive(true);
        ADSUI.SetActive(false);
        ADSButton.SetActive(false);
        PlayADS = false;
        ADSTime = 0;
    }
}
