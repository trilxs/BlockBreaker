using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	public static bool hasStarted = false;
	private Vector3 paddleToBallVector;
	
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>(); //find the type Paddle and connect that to paddle
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
