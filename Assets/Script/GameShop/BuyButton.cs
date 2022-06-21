using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int PlayerMoney;
    public Button ShopBuyButton;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("PlayerMoney");
        
        ShopBuyButton.GetComponent<Button>();
        ShopBuyButton.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        PlayerMoney = PlayerMoney - 5000;
        
        PlayerPrefs.SetInt("PlayerMoney",PlayerMoney);
    }
}
