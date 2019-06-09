using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMethod : MonoBehaviour
{
    public float UpdateMapInterval = 5f;
    public float UpdateMapDistance = 1f;

    private float _updateMapTimer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("UpdatePlayerLooking");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator UpdatePlayerLooking()
    {
        for (; ; )
        {
            UpdateMap();
            yield return new WaitForSeconds(UpdateMapInterval);
        }
    }

    void UpdateMap()
    {
        Debug.Log("UpdateMap");
    }

}
