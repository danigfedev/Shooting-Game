using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour {

    #region Private Variables

    private float Speed = 5.0f;
    private PlayerController controller;

    #endregion

    void Start ()
    {
        controller = GetComponent<PlayerController>();
	}
	
	void Update ()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 velocity = movement.normalized * Speed;
        controller.Move(velocity);


    }
}
