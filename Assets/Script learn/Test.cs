using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnEnable()
    {
        EvenManager.OnClick += Move;
        EvenManager.CanRun += Move;
    }
    private void OnDisable()
    {
        EvenManager.OnClick -= Move;
        EvenManager.CanRun -= Move;
    }
    public void Move()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(5,10);
        transform.position = pos;

    }


    
}
