using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamePlayTest : MonoBehaviour
{
    [Header("狀態")]
    [SerializeField] private bool GetLeft;
    [SerializeField] private bool GetRight;
    [SerializeField] private bool WaitTime;

    [Header("數值")]
    [SerializeField] private float GetButtonTime;

    [Header("物件")]
    [SerializeField] private Text UIText;
    
    // Start is called before the first frame update
    void Start()
    {
        GetButtonTime = 1f;
        GetLeft = false;
        GetRight = false;
        WaitTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        TimeDetection();
    }

    public void GetLeftButton()
    {
        if(GetLeft == false)
        {
            GetLeft = true;
            GetButtonTime = 0f;
            WaitTime =true;
        }
    }

    public void GetRightButton()
    {
        if(GetRight == false)
        {
            GetRight = true;
            GetButtonTime = 0f;
            WaitTime = true; 
        }
    }

    private void TimeDetection()
    {
        GetButtonTime += Time.deltaTime;
        
        if(GetButtonTime >=0.2f&& WaitTime == true)
        {
            BehaviorDetection();
        }
    }

    private void BehaviorDetection()
    {
        WaitTime = false;

        if(GetLeft == true && GetRight == true)
        {
            UIText.text = "防禦";
            GetRight = false;
            GetLeft = false;
        }

        if(GetLeft == false && GetRight == true)
        {
            UIText.text = "右拳";
            GetRight = false;
        }

        if(GetLeft == true && GetRight == false)
        {
            UIText.text = "左拳";
            GetLeft = false;
        }
    }
}
