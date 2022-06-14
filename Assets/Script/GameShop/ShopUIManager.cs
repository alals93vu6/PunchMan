using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    [SerializeField] private int IsGlovePage;

    [SerializeField] public GameObject GloveUI;
    [SerializeField] public GameObject DiamondUI;
    [SerializeField] public GameObject MoneyUI;

    [SerializeField] public Text ChangeButtonText;
    
    // Start is called before the first frame update
    void Start()
    {
        IsGlovePage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGlovePage == 1)
        {
            GloveUI.SetActive(true);
            DiamondUI.SetActive(false);
            MoneyUI.SetActive(false);
            ChangeButtonText.text = "購買鑽石";
        }
        if(IsGlovePage == 2)
        {
            GloveUI.SetActive(false);
            DiamondUI.SetActive(true);
            MoneyUI.SetActive(false);
            ChangeButtonText.text = "購買金幣";
        }
        if(IsGlovePage == 3)
        {
            GloveUI.SetActive(false);
            DiamondUI.SetActive(false);
            MoneyUI.SetActive(true);
            ChangeButtonText.text = "購買拳套";
        }
    }

    public void ChangePageButton()
    {
        if (IsGlovePage == 1)
        {
            IsGlovePage = 2;
        }
        else if (IsGlovePage == 2)
        {
            IsGlovePage = 3;
        }
        else
        {
            IsGlovePage = 1;
        }
    }
}
