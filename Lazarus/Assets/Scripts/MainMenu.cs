using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Test()
    {
        SceneManager.LoadScene("TestLevel");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
