using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killball : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxLiveTime = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= maxLiveTime)
        {
            Destroy(this.gameObject);
        }
    }
}
