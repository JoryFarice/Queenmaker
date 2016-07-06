using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public int enemyHealth = 100;


	
	// Update is called once per frame
	void Update () 
	{
		if (enemyHealth <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}
