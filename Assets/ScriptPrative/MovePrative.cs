using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrative: MonoBehaviour
{
    public Transform target;
    public float speed;
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f;

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime*speed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime*speed;
        transform.Translate(xValue, yValue, zValue);
        //if(Vector2.Distance(transform.position, target.position) < target.position.x)
        //{
          //  transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //}
    }

    
}
