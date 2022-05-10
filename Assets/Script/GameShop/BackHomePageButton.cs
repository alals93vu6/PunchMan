using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Shop;
using UnityEngine;
using UnityEngine.UI;

public class BackHomePageButton : MonoBehaviour
{
    private Button BackHomeButton;
    
    // Start is called before the first frame update
    void Start()
    {
        BackHomeButton = GetComponent<Button>();
        BackHomeButton.onClick.AddListener(BackGomePage);
        
    }

    private void BackGomePage()
    {
        EventBus.Post(new BackHomePageDetected());
    }
}
