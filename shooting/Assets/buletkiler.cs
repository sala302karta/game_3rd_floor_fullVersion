using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buletkiler : MonoBehaviour
{

    public float bulletTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "bullet(Clone)")
        {
            Destroy(this.gameObject, bulletTime);
        }
    }
}
