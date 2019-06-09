using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp(float modificator)
    {
        transform.Translate(Vector3.up * speed * modificator);
    }

    public void MoveDown(float modificator)
    {
        transform.Translate(Vector3.down * speed * modificator);
    }

    public void MoveLeft(float modificator)
    {
        transform.Translate(Vector3.left * speed * modificator);
    }

    public void MoveRight(float modificator)
    {
        transform.Translate(Vector3.right * speed * modificator);
    }
}
