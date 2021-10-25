using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action<int> testAction;
    // Start is called before the first frame update
    void Start()
    {
        //testAction.method
    }

    // Update is called once per frame
    void Update()
    {

    }
}
