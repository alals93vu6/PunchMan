using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymADS : MonoBehaviour
{
    public int PLV;
    // Start is called before the first frame update
    void Start()
    {
        PLV = PlayerPrefs.GetInt("NowPlayerHPLV");
        PLV++;
        PlayerPrefs.SetInt("NowPlayerHPLV",PLV);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
