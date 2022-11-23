using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 target;
    public float speed;

    public void Start()
    {
        //target = FindObjectOfType<Player>().transform.position;
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void Update()
    {
    transform.position = Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
        if(transform.position == target)
        {
            Destroy(gameObject);
        }
    }
}
