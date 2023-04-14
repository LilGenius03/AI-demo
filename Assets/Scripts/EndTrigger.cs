using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    
    public void EndGame()
    {
        SceneManager.LoadScene("PlayerWins");
        
    }

    public void Lose()
    {
        SceneManager.LoadScene("AIWins");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            EndGame();
        }

        if(other.CompareTag("AI"))
        {
            Lose();
        }

    }
}
