using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{


    [Header("Data")]
    private bool isControlling;


    [Header("Components")]
    [SerializeField]private Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManagePlayerInput();
    }
    private void ManagePlayerInput()                   //Đây là hàm quản lý thao tác điều khiển đầu vào
    {
        if (Input.GetMouseButtonDown(0))
        {
            isControlling= true;
            player.MouseDownCallBack();
        }

        else if (Input.GetMouseButton(0))
        {
            if (isControlling)
                player.MouseDragCallBack();
            else
            {   
                isControlling= true;
                player.MouseDownCallBack();
            }
        }
        else if (Input.GetMouseButtonUp(0) && isControlling)
        {
            isControlling= false;
            player.MouseUpCallBack();
        }
    }
}
