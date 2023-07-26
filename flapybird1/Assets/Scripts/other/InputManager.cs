using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
     public KeyCode key;
     public VectorIntroduction objectNeedMove;
     void Start()
    {
        Debug.Log("This is inputManager run on Start()");
        objectNeedMove = GetComponent<VectorIntroduction>();
    }

    // Update is called once per frame
    void Update()
    {
        InputAxis();
    }
    protected void InputAxis()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal"); // -1..0..1
        float verticalAxis = Input.GetAxisRaw("Vertical");

        objectNeedMove.Move(new Vector3(horizontalAxis, verticalAxis, 0));

    }
    protected void InputMouseClick()
    {
        bool startClick = Input.GetMouseButtonDown(0);
        bool holdClick = Input.GetMouseButton(0);
        bool releaseClick = Input.GetMouseButtonUp(0);

        if(startClick == true) Debug.Log("Bắt đầu click chuột");
        if(holdClick == true) Debug.Log("Đang giữ chuột");
        if(releaseClick == true) Debug.Log("Đã nhả chuột");
    }
    protected void InputKeyboard()
    {
        bool startPressKey = Input.GetKeyDown(key);
        bool holdPressKey = Input.GetKey(key);
        bool releasePressKey = Input.GetKeyUp(key);

        if(startPressKey == true) Debug.Log("Bắt đầu nhấn phím " + key);
        if(holdPressKey == true) Debug.Log("Đang giữ phím " + key);
        if(releasePressKey == true) Debug.Log("Đã nhả phím " + key);

    }
}
