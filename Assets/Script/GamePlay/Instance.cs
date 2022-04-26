using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance<T> : MonoBehaviour
{
    public static T instacne;

    private void Awake()
    {
        instacne = GetComponent<T>();
    }
}
