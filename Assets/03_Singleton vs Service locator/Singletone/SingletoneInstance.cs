using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletoneInstance : MonoBehaviour
{
    static public SingletoneInstance Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Method1(string parameter1)
    {
        Debug.Log("SingletoneInstance " + parameter1);
    }
}
