using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class PageRotaryB : MonoBehaviour
{
    [SerializeField] private List<int> Target = new List<int>();

    [SerializeField] public int Index;
     
    // Start is called before the first frame update
    void Start()
    {
        Index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentStatus();
        if (Index >= 3) Index = 0;
        if (Index <= -1) Index = 2;
        Index = Mathf.Clamp(Index ,0 , 2);
        Camera.main.transform.rotation =
            Quaternion.Lerp(Camera.main.transform.rotation, Quaternion.Euler(0, Target[Index], 0), 0.05f);
        
        
    }

    public void PageLeftMove()
    {
        Index--;
    }

    public void PageRightMOve()
    {
        Index++;
    }
    

    public void CurrentStatus()
    {
        if(Index == 0)
        {
            EventBus.Post(new InGameStartReady());
        }
        else if(Index == 1)
        {
            EventBus.Post(new InGym());
            
        }
        else
        {
            EventBus.Post(new InShop());
            
        }
    }

    
}
