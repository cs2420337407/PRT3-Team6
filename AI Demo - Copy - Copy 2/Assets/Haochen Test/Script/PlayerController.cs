using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float ver = 0;
	float hor = 0;
	public float turnspeed = 10;
	public float MoveSpeed = 1.0f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		hor = Input.GetAxis("Horizontal");
		ver = Input.GetAxis("Vertical");

		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
		}

	}

}
