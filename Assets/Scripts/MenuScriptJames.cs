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

	public void HardMode()
    {
		SceneManager.LoadScene("AI demo Hard");
		Debug.Log("HardMode");
    }

	public void EasyMode()
    {
		SceneManager.LoadScene("AI demo Easy");
		Debug.Log("EasyMode");
	}


}