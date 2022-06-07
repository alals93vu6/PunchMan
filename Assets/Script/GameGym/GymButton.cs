using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Gym;
using UnityEngine;

public class GymButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonOnclike()
    {
        EventBus.Post(new HitGymButtonDetected());
    }
}
