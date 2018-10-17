using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

    private Rigidbody rigidbody;
    private Vector3 velocity;

	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position+velocity*Time.fixedDeltaTime);
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void Rotate(Vector3 hitPoint)
    {
        //First correct point:
        Vector3 correctedPoint = new Vector3(hitPoint.x, transform.position.y, hitPoint.z);
        transform.LookAt(correctedPoint);
    }
}
