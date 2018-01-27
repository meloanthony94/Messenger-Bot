using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessengerBot : MonoBehaviour {

    float MoveDistance = 1.5f;

    public void Move(int direction)
    {
        if (direction == -1) //Left
        {
            if(transform.position.x > -MoveDistance)
                transform.position = transform.position + (Vector3.right * -MoveDistance);
        }
        else
            if (transform.position.x < MoveDistance)
                transform.position = transform.position + (Vector3.right * MoveDistance);
    }
}
