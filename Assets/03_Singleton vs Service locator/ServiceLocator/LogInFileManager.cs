using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogInFileManager : MonoBehaviour, ILogManager
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
        Debug.Log("LogInFileManager " + parameter1);
    }
}
