using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GymUIManager : MonoBehaviour
{
    [SerializeField] public GymLVManager GymLV;
    
    [SerializeField] private Text GymButtonText;
    [SerializeField] private Text PowerNowLV;
    [SerializeField] private Text NeedMoneyAndTime;
    [SerializeField] private Text NeedMoney;
    [SerializeField] private Text HaveMoney;

    // Start is called before the first frame update
    void Start()
    {
        GymLV = GetComponent<GymLVManager>();
        
        ReadyUP();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadyUP()
    {
        GymButtonText.text = "開始升級";
        PowerNowLV.text = "現在等級：" + GymLV.PlayerLV;
        NeedMoneyAndTime.text = "升級所需時間：" + GymLV.PlayerNeedTime;
        NeedMoney.text = "升級所需金錢：" + GymLV.PlayerNeedMoney;
        HaveMoney.text = "擁有金錢：" + GymLV.PlayerMoney;

    }

    public void UPing()
    {
        GymButtonText.text = "快進過程";
        PowerNowLV.text = "現在等級：" + GymLV.PlayerLV;
        NeedMoney.text = " ";
        HaveMoney.text = " ";

    }

    public void MoneyChanges()
    {
        NeedMoneyAndTime.text = "完成時間剩餘：" + GymLV.PlayerNeedTime;
    }

    public void EnoughMoney()
    {
        GymButtonText.text = "金錢不足";
    }
}
