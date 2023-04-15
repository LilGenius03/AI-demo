using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnsInsultsScript : MonoBehaviour
{
    public string[] insults = { "My mum is faster than that!", "I can beat you with my eyes closed!", "They should rename driving too slow law after you!", "How stupid can you be!", "If I'm the hare than your definetly the tortuse!" };
    public float insultDistance = 5.0f;

    public float insultCooldown = 2.0f; 
    private float lastInsultTime = 0.0f;

    private void Update()
    {
        GameObject[] aiGameObjects = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject aiGameObject in aiGameObjects)
        {
            if (aiGameObject != this.gameObject)
            {
                float distance = Vector3.Distance(transform.position, aiGameObject.transform.position);

                if (distance <= insultDistance && Time.time > lastInsultTime + insultCooldown)
                {
                    string insult = GetRandomInsult();
                    Debug.Log(insult);

                    lastInsultTime = Time.time;
                }
            }
        }
    }

    private string GetRandomInsult()
    {
        int index = Random.Range(0, insults.Length);
        return insults[index];
    }
}











