using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button start;
    public Image Panel;
   
    private void Awake()
    {
        Time.timeScale = 0f;  
    }

    private void OnEnable()
    {
        start.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        start.onClick.RemoveListener(StartGame);

    }

    private void StartGame()
    {
        Time.timeScale = 1f;

        start.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
    }
}
