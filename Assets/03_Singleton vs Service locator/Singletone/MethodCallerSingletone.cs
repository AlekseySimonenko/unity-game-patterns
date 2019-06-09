using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodCallerSingletone : MonoBehaviour
{
    //True dependency organization
    private SingletoneInstance singletoneInstance { get => SingletoneInstance.Instance;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //C# VARIANT
            SingletoneStatic.Method1("I'm clasic C# singletone");
            //BEST VARIANT
            singletoneInstance.Method1("I'm compromise singletone");
            //BAD VARIANT
            SingletoneBad.Method1("I'm bad singletone");
        }
            
    }
}
