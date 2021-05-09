using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float ver = 0;
	float hor = 0;
	public float turnspeed = 10;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		hor = Input.GetAxis("Horizontal");
		ver = Input.GetAxis("Vertical");

	}
	void Rotating(float hor, float ver)
	{
		//Get Direction
		Vector3 dir = new Vector3(hor, 0, ver);
		//Direct to 4
		Quaternion quaDir = Quaternion.LookRotation(dir, Vector3.up);
		//slow trun
		transform.rotation = Quaternion.Lerp(transform.rotation, quaDir, Time.fixedDeltaTime * turnspeed);



	}

	void FixedUpdate()
	{


		if (hor != 0 || ver != 0)
		{
			//rotaing
			Rotating(hor, ver);



		}
	}
}
