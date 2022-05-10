using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePageUIManager : MonoBehaviour
{
    public Text CurrenStatusText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerInReady()
    {
        CurrenStatusText.text = "點擊進入遊戲";
    }
    
    public void PlayerInShop()
    {
        CurrenStatusText.text = "點擊進入商城";
    }
    
    public void PlayerInGym()
    {
        CurrenStatusText.text = "點擊開始訓練";
    }
}
