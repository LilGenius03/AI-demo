using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearScript : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;

    void Start()
    {

        min = transform.position.z;
        max = transform.position.z + 1.25f;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, max - min) + min);

    }
}
