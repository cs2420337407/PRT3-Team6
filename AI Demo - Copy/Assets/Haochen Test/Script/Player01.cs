using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
	//Camera Flow
	public Transform target;
	Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	void Update()
	{
		transform.position = target.position + offset;
		Rotate();
		Scale();

	}

	// Scale
	private void Scale()
	{
		float dis = offset.magnitude;
		dis += Input.GetAxisRaw("Mouse ScrollWheel") * 5;
		//Debug.Log("dis=" + dis);
		if (dis < 10 || dis > 40)
		{
			return;
		}
		offset = offset.normalized * dis;
	}

	// LeftRightUpDown move
	private void Rotate()
	{
		if(Input.GetMouseButton(1))
		{
			Vector3 pos = transform.position;
			Vector3 rot = transform.eulerAngles;

			transform.RotateAround(Vector3.zero, Vector3.up, Input.GetAxisRaw("Mouse X") * 10);
			transform.RotateAround(Vector3.zero, Vector3.left, Input.GetAxisRaw("Mouse Y") * 10);
			float x = transform.eulerAngles.x;
			float y = transform.eulerAngles.y;
			//Debug.Log("x= " + x);
			//Debug.Log("y= " + y);
			//Control Move Limited area
			if (x < 20 || x > 45 || y < 0 || y > 40)
			{
				transform.position = pos;
				transform.eulerAngles = rot;
			}
			// Update diff
			offset = transform.position - target.position;
		}
	}
}

