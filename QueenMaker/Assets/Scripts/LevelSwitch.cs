using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour {

	// Use this for initialization
	public void MainMenu () 
	{

	}
	
	// Update is called once per frame
	public void LevelOne () 
	{
	
	}

	public void LevelTest () 
	{
		SceneManager.LoadScene(1);
	}
}
