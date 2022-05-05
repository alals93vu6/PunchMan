using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageRotary : MonoBehaviour
{
    [SerializeField] public bool IsTurn;
    public bool AtBR;
    public bool BtCR;
    public bool CtAR;
    public bool AtCL;
    public bool BtAL;
    public bool CtBL;

    public GameObject CamearCtrl;

    [SerializeField] private float YTest;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        YTest = CamearCtrl.transform.rotation.y;
        
        CamearMove();
        
    }

    public void CamearMove()
    {
        if (AtBR && CamearCtrl.transform.rotation.y >= -0.25f)
        {
            CamearCtrl.transform.Rotate(Vector3.down * Time.deltaTime * 60f);
        }
        
        if (BtCR && CamearCtrl.transform.rotation.y <= 0.25f)
        {
            CamearCtrl.transform.Rotate(Vector3.up * Time.deltaTime * 80f);
        }
        
        if (CtAR && CamearCtrl.transform.rotation.y >= 0)
        {
            CamearCtrl.transform.Rotate(Vector3.down * Time.deltaTime * 60f);
        }
        
        if (AtCL && CamearCtrl.transform.rotation.y <= 0.25f)
        {
            CamearCtrl.transform.Rotate(Vector3.up * Time.deltaTime * 60f);
        }
        
        if (BtAL && CamearCtrl.transform.rotation.y <= 0)
        {
            CamearCtrl.transform.Rotate(Vector3.up * Time.deltaTime * 60f);
        }
        
        if (CtBL && CamearCtrl.transform.rotation.y >= -0.25f)
        {
            CamearCtrl.transform.Rotate(Vector3.down * Time.deltaTime * 80f);
        }
    }

    public void AtoBTurnRight()
    {
        AtBR = true;
        BtCR = false;
        CtAR = false;
        AtCL = false;
        BtAL = false;
        CtBL = false;
    }
    
    public void BtoCTurnRight()
    {
        BtCR = true;
        AtBR = false;
        CtAR = false;
        AtCL = false;
        BtAL = false;
        CtBL = false;
    }
    
    public void CtoATurnRight()
    {
        CtAR = true;
        AtBR = false;
        BtCR = false;
        AtCL = false;
        BtAL = false;
        CtBL = false;
    }
    
    public void AtoCTurnLeft()
    {
        AtCL = true;
        AtBR = false;
        BtCR = false;
        CtAR = false;
        BtAL = false;
        CtBL = false;
    }
    
    public void BtoATurnLeft()
    {
        BtAL = true;
        AtBR = false;
        BtCR = false;
        CtAR = false;
        AtCL = false;
        CtBL = false;
    }
    
    public void CtoBTurnLeft()
    {
        CtBL = true;
        AtBR = false;
        BtCR = false;
        CtAR = false;
        AtCL = false;
        BtAL = false;
    }
}
