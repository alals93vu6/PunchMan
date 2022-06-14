using System.Collections;
using System.Collections.Generic;
using Project;
using Project.GamePlay;
using UnityEngine;

public class ReBornButton : MonoBehaviour
{
    
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

    public void ReBornClick()
    {
        if (PlayerHaveDiamond >= 50)
        {
            PlayerHaveDiamond = PlayerHaveDiamond - 50;
            PlayerPrefs.SetInt("PlayerDiamond",PlayerHaveDiamond);
            
            EventBus.Post(new PlayerRebirthDetected());
        }
    }
}
