using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour {

    #region Private Variables

    private float Speed = 5.0f;
    private PlayerController controller;
    private Camera viewCamera;

    #endregion

    void Start ()
    {
        controller = GetComponent<PlayerController>();
        viewCamera = Camera.main;
	}
	
	void Update ()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 velocity = movement.normalized * Speed;
        controller.Move(velocity);

        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if(groundPlane.Raycast(ray,out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            controller.Rotate(point);
        }
        

    }
}
