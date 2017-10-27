using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public float speed = 10;

	void FixedUpdate ()
	{
		//将输入内容带入x和z
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (x * speed, 0, z * speed);
	}

}
