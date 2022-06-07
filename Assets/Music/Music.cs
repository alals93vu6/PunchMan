using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource Sound_Attack;
    public AudioSource Sound_Attack1;
    public AudioSource Sound_Def;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Sound_Attack, this.transform.position, new Quaternion(0, 0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(Sound_Attack1, this.transform.position, new Quaternion(0, 0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(Sound_Def, this.transform.position, new Quaternion(0, 0, 0, 0));
        }
    }
}
