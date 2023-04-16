using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    void Update()
    {
        var rotation = Quaternion.LookRotation(Vector3.back, Vector3.up);
        transform.rotation = rotation;
    }
}
