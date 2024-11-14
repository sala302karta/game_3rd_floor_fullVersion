using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class buletkiler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name == "bullet(Clone)")
        {
            this.gameObject.GetComponent<TrailRenderer>().enabled = true;
            Destroy(this.gameObject, 5f);
        }

    }

    private async void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.name == "bullet(Clone)")
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ParticleSystem explode = this.gameObject.GetComponent<ParticleSystem>();
            explode.Play();
            Destroy(this.gameObject, 0.08f);
        }
    }

}
