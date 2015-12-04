using UnityEngine;
using System.Collections;

public class ShipPilot : MonoBehaviour {

	private Rigidbody _rb;

	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		//Ship engins always move forward
		_rb.AddRelativeForce (Input.GetAxis ("Speed") * Vector3.forward * 10);

		var direction = Quaternion.Euler (-Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal"), 0f);

		//Order matters
		_rb.rotation = _rb.rotation * direction;

		_rb.velocity = _rb.rotation * _rb.velocity;
	}
}
