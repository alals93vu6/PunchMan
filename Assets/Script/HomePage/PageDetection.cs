using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class PageDetection : MonoBehaviour
{
    Vector2 first = Vector2.zero;
    Vector2 second = Vector2.zero;

    public static int page_now = 1;
    //city  = 1 主畫面
    //store = 2 商店
    //train = 3 訓練
    [SerializeField] bool ispagemove = false;
    [SerializeField] int direction = 0;
    //方向
    //1 = left
    //2 = right
    bool ismouse = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(page_now);
        movemouse();
        move_page();
        Chage();
    }

    void movemouse()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            first = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            second = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            ismouse = true;
        }
    }
    void move_page()
    {
        if (first.y - second.y <= 0.4f && first.y - second.y >= -0.4f && ismouse == true)
        {
            //left
            if (first.x - second.x <= -0.3f)
            {
                direction = 1;
                ispagemove = true;

            }
            //right
            else if (first.x - second.x >= 0.3f)
            {
                direction = 2;
                ispagemove = true;

            }
        }


        else if (first.x == second.x && first.y == second.y)
        {
            direction = 0;
            ispagemove = false;
        }
    }

    void page_move_left()
    {
        //left
        if (page_now == 1)
        {
            //move to store
            page_now = 2;
            EventBus.Post(new AtoBRightMove());
        }
        else if (page_now == 2)
        {
            //move to train
            page_now = 3;
            EventBus.Post(new BtoCRightMove());
        }
        else if (page_now == 3)
        {
            //move to city
            page_now = 1;
            EventBus.Post(new CtoARightMove());
        }
    }
    void page_move_right()
    {
        //right
        if (page_now == 1)
        {
            //move to train
            page_now = 3;
            EventBus.Post(new AtoCLeftMove());
            //transform.Rotate(0,90,0);
        }
        else if (page_now == 2)
        {
            //move to city
            page_now = 1;
            EventBus.Post(new BtoALeftMove());
        }
        else if (page_now == 3)
        {
            //move to store
            page_now = 2;
            EventBus.Post(new CtoBLeftMove());
        }
    }

    void Chage()
    {
        if (ispagemove == true)
        {
            if (direction == 1)
            {
                page_move_left();
            }
            if (direction == 2)
            {
                page_move_right();
            }
            first = Vector2.zero;
            second = Vector2.zero;
            ispagemove = false;
            direction = 0;
            ismouse = false;
        }
    }
}

