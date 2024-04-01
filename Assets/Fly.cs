using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{

    public GameObject choppedFruit, leftSword, rightSword;

    Rigidbody rb;
    float force = 10f;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            transform.forward = Vector3.Slerp(transform.forward, rb.velocity.normalized, force * Time.deltaTime);
            rb.AddForce(force * Vector3.up, ForceMode.Impulse);
            count++;
        }

        if (transform.position.y <= -20)
            Destroy(this.gameObject);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Score.score++;
        Destroy(this.gameObject);

        GameObject g1 = Instantiate(choppedFruit, new Vector3(transform.position.x, transform.position.y, transform.position.z), new Quaternion(transform.rotation.x + .5f, transform.rotation.y, transform.rotation.z, 0f));
        GameObject g2 = Instantiate(choppedFruit, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        
        Rigidbody rb2 = g2.GetComponent<Rigidbody>();
        rb2.AddExplosionForce(20f, new Vector3(transform.position.x, transform.position.y, transform.position.z), .5f, 3f);

        Debug.Log("REAHCER");

    }


}
