using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondButton : MonoBehaviour
{
    public int AddNumber;

    [SerializeField] private int PlayerHaveDiamond;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerHaveDiamond = PlayerPrefs.GetInt("PlayerDiamond");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyDiamond()
    {
        PlayerHaveDiamond = PlayerPrefs.GetInt("PlayerDiamond");

        PlayerHaveDiamond = PlayerHaveDiamond + AddNumber;
        PlayerPrefs.SetInt("PlayerDiamond",PlayerHaveDiamond);

    }
}
