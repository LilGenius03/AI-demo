using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScriptJames : MonoBehaviour
{
		public void PlayGame()
		{
			SceneManager.LoadScene("AI demo");
		}

	public void QuitGame()
    {
		Application.Quit();
		Debug.Log("Quit");
    }


}