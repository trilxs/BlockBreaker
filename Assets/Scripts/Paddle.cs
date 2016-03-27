using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float mousePosInBlocks;
	public Ball ball;
	
	void Update () {
		if (!LevelManager.autoPlay) {
			mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
			Vector3 paddlePos = new Vector3(Mathf.Clamp (mousePosInBlocks, 0.5f, 15.5f), 0.5f, 0f);
			transform.position = paddlePos;
		}
		else {
			AutoPlay();
		}
	}
	
	void AutoPlay() {
		float ballPosx = GameObject.Find ("Ball").transform.position.x;
		Vector3 paddlePos = new Vector3(Mathf.Clamp (ballPosx, 0.5f, 15.5f), 0.5f, 0f);
		transform.position = paddlePos;
	}
}
	

/*		MousePosition could also be done this way:
		Vector3 paddlePos = newVector(0f, 0.5f, 0f);
		paddlePos.x = Mathf.Clamp( Input.mousePosition.x / Screen.width * 16);
		transform.position = paddlePos;
*/
