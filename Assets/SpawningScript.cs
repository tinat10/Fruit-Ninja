using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{

    public GameObject [] fruit;
    GameObject fruity;
    System.Random random;

    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        random = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time > 1f)
        {
            int num = random.Next(0, 3);
            //Debug.Log(num + " ");

            float x = (float)(random.NextDouble() * (2 + 2) - 2);
            float z = (float)(random.NextDouble() * (1 + 1) -1);
            //    return random.NextDouble() * (maximum - minimum) + minimum;

            fruity = Instantiate(fruit[num], new Vector3(x, transform.position.y, z), transform.rotation);
            time = 0f;
        }

    }
}
