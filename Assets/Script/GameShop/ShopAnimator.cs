using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAnimator : MonoBehaviour
{
    private Animator ShopAN;
    
    // Start is called before the first frame update
    void Start()
    {
        ShopAN = GetComponent<Animator>();
        ShopAN.Play("Standby");
    }
}
