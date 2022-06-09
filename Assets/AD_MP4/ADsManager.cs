using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADsManager : MonoBehaviour
{
    public GameObject ADSButton;

    private float ADSTIME;
    
    // Start is called before the first frame update
    void Start()
    {
        ADSButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ADSTIME += Time.deltaTime;

        if (ADSTIME >= 5)
        {
            ADSButton.SetActive(true);
        }
    }
}
