using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenManager : MonoBehaviour
{
    public delegate void Click();
    public static event Click OnClick;

    public delegate void Run();
    public static event Run CanRun;

   

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(1))
        {
            if(CanRun != null)
            {
                CanRun();
                //CanRun.Invoke();
            }
        }
    }
}
