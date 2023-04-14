using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowerScript : MonoBehaviour
{
    public float speed;
    public int MaxNum;
    int pointIndex;
    Transform movePoint;
    public Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        pointIndex = 0;
        movePoint = points[pointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, movePoint.position) <= 0)
        {
            if(pointIndex > MaxNum)
            {
                pointIndex = 0;
            }

            pointIndex++;
            movePoint = points[pointIndex];
        }
    }

    
}
