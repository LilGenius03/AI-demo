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

        Vector3 toPlayer = Player[0].transform.position - transform.position;
        Vector3 toAI = AI[0].transform.position - transform.position;

        Vector3 midpoint = new Vector3((toPlayer.x + toAI.x) / 2.0f, (toPlayer.y + toAI.y) / 2.0f, (toPlayer.z + toAI.z) / 2.0f);


        //Vector3 newLocation = new Vector3(midpoint.transform.position.x, transform.position.y, transform.position.z);
        Vector3 newLocation = new Vector3(midpoint.x, transform.position.y, transform.position.z);
        
        SetCommentatorTargetLocation(newLocation);

    }



    public void SetCommentatorTargetLocation(Vector3 targetLocation)
    {

        _navMeshAgent.SetDestination(targetLocation);

    }
}
