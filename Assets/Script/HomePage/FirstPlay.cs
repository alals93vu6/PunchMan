using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlay : MonoBehaviour
{

    public int NowLV;

    public int PlayerHP;

    public int PlayerPower;
    // Start is called before the first frame update
    void Start()
    {
        NowLV = PlayerPrefs.GetInt("NowGameLV");
        PlayerHP = PlayerPrefs.GetInt("NowPlayerHPLV");
        PlayerPower = PlayerPrefs.GetInt("NowPlayerPowerLV");
        
        FirstGameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FirstGameStart()
    {
        if (NowLV <= 1)
        {
            PlayerPrefs.SetInt("NowGameLV",1);
        }
        if (PlayerHP <= 1)
        {
            PlayerPrefs.SetInt("NowPlayerHPLV",1);
        }
        if (PlayerPower <= 1)
        {
            PlayerPrefs.SetInt("NowPlayerPowerLV",1);
        }
    }
}
