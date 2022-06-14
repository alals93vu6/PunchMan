using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Shop;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private ShopUIManager ShopUICtrl;
    
    // Start is called before the first frame update
    void Start()
    {
        ShopUICtrl = GetComponent<ShopUIManager>();
        
        EventBus.Subscribe<BackHomePageDetected>(OnBackHomePage);
        EventBus.Subscribe<ChangePageDetected>(OnChangePage);
    }

    private void OnChangePage(ChangePageDetected obj)
    {
        ShopUICtrl.ChangePageButton();
        
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
