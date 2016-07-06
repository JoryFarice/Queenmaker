using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
