using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    private PageRotary pageRotary;
    // Start is called before the first frame update
    void Start()
    {
        pageRotary = GetComponent<PageRotary>();
        
        EventBus.Subscribe<GameStartDetected>(OnGameStartDetected);
        EventBus.Subscribe<QuitGameDetected>(OnQuitGameDetected);
        EventBus.Subscribe<HitShopDetected>(OnHitShopDetected);
        EventBus.Subscribe<AtoBRightMove>(OnAtoBRightMove);
        EventBus.Subscribe<BtoCRightMove>(OnBtoCRightMove);
        EventBus.Subscribe<CtoARightMove>(OnCtoARightMove);
        EventBus.Subscribe<AtoCLeftMove>(OnAtocLeftMove);
        EventBus.Subscribe<BtoALeftMove>(OnBtoALeftMove);
        EventBus.Subscribe<CtoBLeftMove>(OnCtoBLeftMove);
    }

   
    private void OnQuitGameDetected(QuitGameDetected obj)
    {
        Application.Quit();
        Debug.Log("砍GAME囉");
    }

    private void OnGameStartDetected(GameStartDetected obj)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
    }

    private void OnAtoBRightMove(AtoBRightMove obj)
    {
        
        pageRotary.AtoBTurnRight();
    }

    private void OnBtoCRightMove(BtoCRightMove obj)
    {
        
        pageRotary.BtoCTurnRight();
    }

    private void OnCtoARightMove(CtoARightMove obj)
    {
        
        pageRotary.CtoATurnRight();
    }

    private void OnAtocLeftMove(AtoCLeftMove obj)
    {
        
        pageRotary.AtoCTurnLeft();
    }

    private void OnBtoALeftMove(BtoALeftMove obj)
    {
        
        pageRotary.BtoATurnLeft();
    }

    private void OnCtoBLeftMove(CtoBLeftMove obj)
    {
        
        pageRotary.CtoBTurnLeft();
    }

    private void OnHitShopDetected(HitShopDetected obj)
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
