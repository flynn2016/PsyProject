using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public float CameraFollowSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetPos = new Vector3 (target.position.x,this.transform.position.y, target.position.z);
		this.transform.position = Vector3.Lerp (this.transform.position, targetPos, Time.deltaTime*CameraFollowSpeed);
	}
}
