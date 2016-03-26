using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;
	
	void Start () {
		paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			//Lock the ball relative to the paddle
			transform.position = paddle.transform.position + paddleToBallVector;
			} 
		if (Input.GetMouseButtonDown (0) && !hasStarted) {
			//The game has started. Give the ball some velocity
			hasStarted = true;
			this.rigidbody2D.velocity = new Vector2 (2f, 10f);
		}
	}
}
