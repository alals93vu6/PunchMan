using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVManager : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public int EnemyHPLV;
    [SerializeField] public int PlayerHPLV;
    [SerializeField] public int NowLV;
    [SerializeField] public int NowHPLV;
    [SerializeField] public int NowPowerLV;

    private UIManager UICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        UICtrl = GetComponent<UIManager>();
        NowLV = PlayerPrefs.GetInt("NowGameLV");
        NowHPLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        NowPowerLV = PlayerPrefs.GetInt("NowPlayerPowerLV");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerHPSet()
    {
        
    }
}
