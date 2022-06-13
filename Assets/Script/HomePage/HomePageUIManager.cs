using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePageUIManager : MonoBehaviour
{
    public Text CurrenStatusText;

    public Text Lvtext;

    public Text MoneyText;

    public Text DiamondText;

    private int nowLV;

    private int nowMoney;

    private int nowDiamond;
    // Start is called before the first frame update
    void Start()
    {
        ShowNowLV();
        ShowMoney();
        ShowDiamond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowNowLV()
    {
        nowLV = PlayerPrefs.GetInt("NowGameLV");
        if (nowLV <= 1)
        {
            nowLV = 1;
            PlayerPrefs.SetInt("NowGameLV",1);
        }
        Lvtext.text = "第" + nowLV + "關";
    }

    private void ShowMoney()
    {
        nowMoney = PlayerPrefs.GetInt("PlayerMoney");
        MoneyText.text = "：" + nowMoney;
    }

    private void ShowDiamond()
    {
        nowDiamond = PlayerPrefs.GetInt("PlayerDiamond");
        DiamondText.text = "：" + nowDiamond;

    }

    public void PlayerInReady()
    {
        CurrenStatusText.text = "點擊進入遊戲";
    }
    
    public void PlayerInShop()
    {
        CurrenStatusText.text = "點擊進入商城";
    }
    
    public void PlayerInGym()
    {
        CurrenStatusText.text = "點擊開始訓練";
    }
}
