using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverbackHome : MonoBehaviour
{
    public Button BackHome;
    // Start is called before the first frame update
    void Start()
    {
        //BackHome.GetComponent<Button>();
        BackHome.onClick.AddListener(BackHomeButton);
    }

    private void BackHomeButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HomePage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
