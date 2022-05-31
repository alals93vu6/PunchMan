using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_del_unity : MonoBehaviour
{
    // Start is called before the first frame update
    public int Page_now_int = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
        if (PageDetection.page_now == Page_now_int)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

}
