using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymLVManager : MonoBehaviour
{
    [SerializeField] public int PlayerLV;
    [SerializeField] public int PlayerMoney;
    [SerializeField] public int PlayerNeedMoney;
    [SerializeField] private float PlayerNeedMOneyFloat;
    [SerializeField] public int PlayerNeedTime;
    [SerializeField] private float PlayerNeedTimeFloat;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        PlayerMoney = PlayerPrefs.GetInt("PlayerMoney");
        PlayerNeedMoney = 3000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
