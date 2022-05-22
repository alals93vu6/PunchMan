using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;
using UnityEngine.UI;

public class AltF4Button : MonoBehaviour
{
    public Button quitButton;
    
    void Start()
    {
        //quitButton.GetComponent<Button>();
        quitButton.onClick.AddListener(AltF4);
    }

    private void AltF4()
    {
        EventBus.Post(new QuitGameDetected());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
