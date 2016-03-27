using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public AudioClip crack;
	public AudioClip destroyed;
	private LevelManager levelManager;
	private int timesHit;
	private bool isBreakable;
	
	void Start () {
	isBreakable = (this.tag == "Breakable");
	if (isBreakable) breakableCount++;
	levelManager = GameObject.FindObjectOfType<LevelManager>();
	timesHit = 0;
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable) {
			HandleHits();
		}
	}
	
	void HandleHits () {
		timesHit++;
		int maxHits = hitSprites.Length + 1; 
		if (timesHit >= maxHits) {
			breakableCount--;
			Debug.Log (breakableCount);
			AudioSource.PlayClipAtPoint (destroyed, transform.position);
			levelManager.SimulateWin ();
			Destroy (gameObject);
		}
		else {
			LoadSprites();
		}
	}
	
	void LoadSprites () {
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex]; 	
		}
	}
}
