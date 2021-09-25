using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSimulator : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // get the mouse touch position to world position by;
    // Vector3 pos = camera.ScreenToWorldPoint(MousePosiiton());

    public bool MouseTouchBegin()      // mouse touch begin
    {
        return  Input.GetMouseButtonDown(0);
    }

    public bool MouseTouchEnded()      // mouse touch ended
    {
        return Input.GetMouseButtonUp(0);
    }

    public bool MouseStationary()      // Mouse is not moving
    {
        return (Input.GetAxisRaw("Mouse X") == 0 && Input.GetAxisRaw("Mouse Y") == 0);
    }

    public bool MouseMoved()           // mouse is moving
    {
        return (Input.GetAxisRaw("Mouse X") != 0 || Input.GetAxisRaw("Mouse Y") != 0);
    }

    public Vector3 MousePosition()     // mouse position
    {
        return Input.mousePosition;
    }

}
