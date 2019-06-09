using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogConsoleManager : MonoBehaviour, ILogManager
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Log(string parameter1)
    {
        Debug.Log("LogConsoleManager " + parameter1);
    }
}
