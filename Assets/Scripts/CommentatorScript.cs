using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CommentatorScript : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent _navMeshAgent;

    void Start()
    {

        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    void Update()
    {

        GameObject[] Player = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] AI = GameObject.FindGameObjectsWithTag("AI");

        
      
        

        Vector3 newLocation = new Vector3(Player[0].transform.position.x, transform.position.y, transform.position.z);

        SetCommentatorTargetLocation(newLocation);


     


    }



    private void SetCommentatorTargetLocation(Vector3 targetLocation)
    {

        _navMeshAgent.SetDestination(targetLocation);

    }
}
