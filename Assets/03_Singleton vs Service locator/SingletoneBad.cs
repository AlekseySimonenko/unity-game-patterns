using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletoneBad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    static public void Method1(string parameter1)
    {
        Debug.Log("SingletoneBad " + parameter1);
    }
}