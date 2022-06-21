using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChengeButtonStart : MonoBehaviour
{
    public Button ChangeGlove;

    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    
    // Start is called before the first frame update
    void Start()
    {
        ChangeGlove = GetComponent<Button>();
        ChangeGlove.onClick.AddListener(OnChange);
        
        A.SetActive(true);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
    }

    private void OnChange()
    {
        A.SetActive(true);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
    }
}
