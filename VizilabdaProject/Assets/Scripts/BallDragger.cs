using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDragger : MonoBehaviour {

    public void DragBall()
    {
        // transform.position = Input.GetTouch(0).position;
        transform.position = Input.mousePosition;
    }
}
