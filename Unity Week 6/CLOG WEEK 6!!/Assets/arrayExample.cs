using UnityEngine;
using System.Collections;

public class arrayExample : MonoBehaviour {

	//this is how you create arrays
	//the purpose of the public GameObject is to create the "size" dropdown menu for the arrays

	public GameObject[] thingsToSpawn;

	int testInt;

	int[] street = new int[10];

	// Use this for initialization
	void Start () {
		print(testInt);
		testInt = 10;
		print("testInt is" + testInt);

		print(street[0]);
		street[0] = 490;
		print(street[0]);
		print (street.Length);

		//the following code will move whatever array is 0 upwards when play is chosen

		thingsToSpawn [0].transform.Translate (Vector3.up * 12);

		//this is a for loop

		for (int i = 0; i<thingsToSpawn.Length; i = i + 1) {
			thingsToSpawn [i].transform.Translate (Vector3.up * 3);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
