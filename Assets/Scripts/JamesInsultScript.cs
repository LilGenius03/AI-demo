using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JamesInsultScript : MonoBehaviour
{

    public int randNum;
    public GameObject insultDisp;
    public bool genInsult = false;
 
    // Update is called once per frame
    void Update()
    {
        if (genInsult == false) 
        {
            genInsult = true;

            StartCoroutine(InsultTracker());
        
        }

        IEnumerator InsultTracker()

        {
            randNum = Random.Range(1, 7);
            
            if (randNum == 1)
            {
                insultDisp.GetComponent<Text>().text = "Way to go blockhead!" ;
            }

             if (randNum == 2)
            {
                insultDisp.GetComponent<Text>().text = "You're too stupid to get out of this maze!'" ;
            }

             if (randNum == 3)
            {
                insultDisp.GetComponent<Text>().text = "Moron!" ;
            }

             if (randNum == 4)
            {
                insultDisp.GetComponent<Text>().text = "You lost? Idiot" ;
            }

             if (randNum == 5)
            {
                insultDisp.GetComponent<Text>().text = "You're way too slow!" ;
            }

             if (randNum == 6)
            {
                insultDisp.GetComponent<Text>().text = "Eat my dust!" ;
            }

             if (randNum == 7)
            {
                insultDisp.GetComponent<Text>().text = "You need your mom to guide you out? haha" ;
            }

            yield return new WaitForSeconds (9);
            genInsult = false;
        }


    }
}
