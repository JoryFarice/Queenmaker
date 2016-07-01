using UnityEngine;
using System.Collections;

public class HitboxController : MonoBehaviour 
{
	public float lifeTime = 0.5f;

	void OnTriggerEnter2D(Collider2D col)
	{
		//if collides with whatever, subtract hit points, destroy this hitbox
		//if colliders doesn't hit, plays animation and destroys or disables
		if (col.gameObject.tag == "Enemy")
		{
			Debug.Log ("Hitting an enemy");
			//coll.gameObject.SendMessage("ApplyDamage", 10);
		}	
	}

	void Update()
	{
		if(this.gameObject.activeSelf == true)
		{
			StartCoroutine (DisableTimer());
		}
	}

	IEnumerator DisableTimer()
	{
		yield return new WaitForSeconds(lifeTime);
		this.gameObject.SetActive(false);
	}
}