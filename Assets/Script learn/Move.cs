using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Update()
    {
  
        MovePlayer();
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }


}
