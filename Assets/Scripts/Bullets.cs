using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour
{

	void OnCollisionEnter (Collision collision)
	{
		 
		var hit = collision.gameObject;
		var health = hit.GetComponentInParent<Health> ();
		if (health != null) {
			health.TakeDamage (10);
		}

		Destroy (gameObject);
	}
}
