using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Shop;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<BackHomePageDetected>(OnBackHomePage);
    }

    private void OnBackHomePage(BackHomePageDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
