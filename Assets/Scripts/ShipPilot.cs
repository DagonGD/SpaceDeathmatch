using UnityEngine;
using System.Collections;

public class ShipPilot : MonoBehaviour {

	private Rigidbody _rb;

	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		_rb.AddRelativeForce (Input.GetAxis ("Vertical") * Vector3.forward * Time.deltaTime * 50);
	}
}
