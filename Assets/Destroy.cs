using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb1 = GetComponent<Rigidbody>();
        //rb1.AddExplosionForce(20f, new Vector3(transform.position.x + 3, transform.position.y + 3, transform.position.z + 3), 20f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y <= -5)
            Destroy(this.gameObject);
        

        //Destroy(this.gameObject, 4);
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(gameObject))
            Destroy(this.gameObject);
    }*/
}
