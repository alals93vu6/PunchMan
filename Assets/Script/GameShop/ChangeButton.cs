﻿using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Shop;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeShop()
    {
        EventBus.Post(new ChangePageDetected());
    }
}