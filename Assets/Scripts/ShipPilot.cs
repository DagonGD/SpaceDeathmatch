using UnityEngine;
using System.Collections;

public class ShipPilot : MonoBehaviour {

	private Rigidbody _rb;

	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		//Ship engins always move forward
		_rb.AddRelativeForce (Input.GetAxis ("Vertical") * Vector3.forward * 10);

		var direction = Quaternion.Euler (0f, Input.GetAxis ("Horizontal"), 0f);
		_rb.velocity = direction * _rb.velocity;
		_rb.MoveRotation(Quaternion.LookRotation(_rb.velocity));
		Debug.Log (_rb.velocity);
	}
}
