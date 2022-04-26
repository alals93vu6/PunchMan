using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Instance<UIManager>
{
    [SerializeField] private Text UItext;
    [SerializeField] private Text EnemyHP;
    [SerializeField] private Text PlayerHP;
    

    [SerializeField] public GameObject EnemyAttck;
    [SerializeField] public GameObject EnemyLeftDF;
    [SerializeField] public GameObject EnemyRightDF;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
        EnemyAttck.SetActive(false);
        EnemyLeftDF.SetActive(false);
        EnemyRightDF.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText(string textA)
    {
        UItext.text = textA;
    }

    public void EnemyHPText(int NowHP)
    {
        EnemyHP.text = "敵人血量：" + NowHP;
    }
    
    public void PlayerHPText(int NowHP)
    {
        PlayerHP.text = "玩家血量：" + NowHP;
    }

    public void isAttck()
    {
        EnemyAttck.SetActive(true);
        EnemyLeftDF.SetActive(false);
        EnemyRightDF.SetActive(false);
    }
    
    public void isRightDF()
    {
        EnemyAttck.SetActive(false);
        EnemyLeftDF.SetActive(false);
        EnemyRightDF.SetActive(true);
    }
    
    public void isLeftDF()
    {
        EnemyAttck.SetActive(false);
        EnemyLeftDF.SetActive(true);
        EnemyRightDF.SetActive(false);
    }

    private void GameStart()
    {
        ShowText("無動作");
        EnemyHPText(999);
    }
}
