using UnityEngine;
using System.Collections;

public class ShipPilot : MonoBehaviour {

	public float MoveSpeed;
	public float RotateSpeed;

	private Rigidbody _rb;

	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		_rb.AddRelativeForce (Input.GetAxis ("Speed") * Vector3.forward * MoveSpeed);
		_rb.AddRelativeTorque (new Vector3 (-Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal"), 0f) * RotateSpeed);
	}
}
