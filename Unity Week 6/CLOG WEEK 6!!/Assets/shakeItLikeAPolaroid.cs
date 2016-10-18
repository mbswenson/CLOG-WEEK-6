using UnityEngine;
using System.Collections;

public class shakeItLikeAPolaroid : MonoBehaviour {

	Transform origLocation;
	public float numSecondsToShake = 2f;

	// Use this for initialization

	void Start () {
		origLocation = transform;
	}
	
	// Update is called once per frame

	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			StartCoroutine("shakeCam");
 			}
		}

	//this will eventually become problematic because the camera will slowly drift
		//transform.Translate (Random.insideUnitSphere);

 	IEnumerator shakeCam() {
		//shake for a number of seconds
		float timeLeft = numSecondsToShake;
		while (timeLeft > 0) {
			transform.position = origLocation.position + Random.insideUnitSphere;
			timeLeft -= Time.deltaTime;
			yield return null; //stops the loop from continuing this time
		}

		//return camera to the original position
		transform.position = origLocation.position;
	}
}
