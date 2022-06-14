using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Instance<UIManager>
{
    [Header("遊戲中")] 
    [SerializeField] public GameObject PlayingUI;
    [SerializeField] private Text UItext;
    [SerializeField] public Slider PlayerHPSlider;
    [SerializeField] public float MaxHP;
    [SerializeField] public float NowHP;

    [Header("結算")] 
    [SerializeField] public GameObject SettlementUI;
    [SerializeField] public GameObject WinSettlementButton;
    [SerializeField] public GameObject LoseSettlemenButton;
    [SerializeField] private Text GetMoney;
    [SerializeField] private Text AllMoney;
    [SerializeField] private Text WinorLoseText;



    // Start is called before the first frame update
    void Start()
    {
        GameStart();
        ShowGamePlayingUI();

    }

    // Update is called once per frame
    void Update()
    {
        
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
    
    private void GameStart()
    {
        ShowText("無動作");
    }

    public void ShowGamePlayingUI()
    {
        PlayingUI.SetActive(true);
        SettlementUI.SetActive(false);
        WinSettlementButton.SetActive(false);
        LoseSettlemenButton.SetActive(false);
        Debug.Log("VAR");
    }

    public void ShowSettementUI()
    {
        PlayingUI.SetActive(false);
        SettlementUI.SetActive(true);
        WinSettlementButton.SetActive(true);
        LoseSettlemenButton.SetActive(false);
    }
    
    public void ShowLoseSettementUI()
    {
        PlayingUI.SetActive(false);
        SettlementUI.SetActive(true);
        WinSettlementButton.SetActive(false);
        LoseSettlemenButton.SetActive(true);
    }

    public void PlayerLose()
    {
        WinorLoseText.text = "你失敗了!";
    }
    
    public void PlayerWin()
    {
        WinorLoseText.text = "你贏了!";
    }
}
