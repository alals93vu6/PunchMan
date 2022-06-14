using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBuyButton : MonoBehaviour
{
    public int AddNumber;
    public int NeedNumber;

    [SerializeField] private int PlayerHaveMoney;
    [SerializeField] private int PlayerHaveDiamond;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerHaveDiamond = PlayerPrefs.GetInt("PlayerDiamond");
        PlayerHaveMoney = PlayerPrefs.GetInt("PlayerMoney");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyMoney()
    {
        PlayerHaveDiamond = PlayerPrefs.GetInt("PlayerDiamond");
        PlayerHaveMoney = PlayerPrefs.GetInt("PlayerMoney");
        
        PlayerHaveDiamond = PlayerHaveDiamond - NeedNumber;
        PlayerHaveMoney = PlayerHaveMoney + AddNumber;
        
        PlayerPrefs.SetInt("PlayerDiamond",PlayerHaveDiamond);
        PlayerPrefs.SetInt("PlayerMoney",PlayerHaveMoney);

    }
}
