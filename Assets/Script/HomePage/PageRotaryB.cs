using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageRotaryB : MonoBehaviour
{
    [SerializeField] private List<int> Target = new List<int>();

    [SerializeField] private int Index;
     
    // Start is called before the first frame update
    void Start()
    {
        Index = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
}
