using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{

	 
	// Update is called once per frame
	void Update ()
	{
	//Keep the Healthbar looking at the Main Camera
		transform.LookAt (Camera.main.transform);
	}
}
