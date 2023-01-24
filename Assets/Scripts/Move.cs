using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        MoveObject();
    }

    public void MoveObject()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

  
}
