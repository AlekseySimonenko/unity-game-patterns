using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodCallerServiceLocator : MonoBehaviour
{
    //True dependency organization
    private ILogManager LogManager { get => ServiceLocator.Instance.LogManager; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            LogManager.Log("yeaaaaa!");
        }
            
    }
}
