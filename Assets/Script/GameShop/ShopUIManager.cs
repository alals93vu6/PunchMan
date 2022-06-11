using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    [SerializeField] private bool IsGlovePage;

    [SerializeField] public GameObject GloveUI;
    [SerializeField] public GameObject DiamondUI;

    [SerializeField] public Text ChangeButtonText;
    
    // Start is called before the first frame update
    void Start()
    {
        IsGlovePage = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGlovePage)
        {
            GloveUI.SetActive(true);
            DiamondUI.SetActive(false);
            ChangeButtonText.text = "購買鑽石";
        }
        else
        {
            GloveUI.SetActive(false);
            DiamondUI.SetActive(true);
            ChangeButtonText.text = "購買拳套";
        }
    }

    public void ChangePageButton()
    {
        if (IsGlovePage)
        {
            IsGlovePage = false;
        }
        else
        {
            IsGlovePage = true;
        }
    }
}
