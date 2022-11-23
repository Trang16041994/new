using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float distance;
    public GameObject bullet;
    public float timeBTS = 1.5f;
    public float nextShotTime = 0;
    private void Update()

    {
        if (Time.time > nextShotTime)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShotTime = Time.time + timeBTS;
        }

        //return distance a and b
        if (Vector2.Distance(transform.position, target.position) < distance)
        {
            //move
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
    }
}
