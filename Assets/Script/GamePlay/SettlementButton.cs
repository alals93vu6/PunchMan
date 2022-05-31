using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettlementButton : MonoBehaviour
{
    private Button BackHome;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BkHomePage()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
