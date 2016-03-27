using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public static bool hasStarted = false;
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>(); //find the type Paddle and connect that to paddle
		paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	void Update () {
		if (!hasStarted) {
			//Lock the ball relative to the paddle
			transform.position = paddle.transform.position + paddleToBallVector;
			} 
		if (Input.GetMouseButtonDown (0) && !hasStarted) {
			//The game has started. Give the ball some velocity
			StartGame ();
		}
	}
	
	void StartGame(){
		hasStarted = true;
		if (!LevelManager.autoPlay) {
			if (LevelManager.difficulty == "Easy")		  this.rigidbody2D.velocity = new Vector2 (1f, 5f);
			else if (LevelManager.difficulty == "Medium") this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			else    									  this.rigidbody2D.velocity = new Vector2 (3f, 15f);
		}
		else {
			this.rigidbody2D.velocity = new Vector2 (3f, 15f);
		}
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		Vector2 tweak = new Vector2(Random.Range (0f, 0.2f), Random.Range (0f, 0.2f)); //add random velocity to the ball @ every collision
		if (hasStarted) {
			audio.Play ();
			rigidbody2D.velocity += tweak;
		}
	}
}
