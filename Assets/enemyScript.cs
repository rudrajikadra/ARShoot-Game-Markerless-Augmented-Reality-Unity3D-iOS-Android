using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {



	// Use this for initialization
	void Start () {

		StartCoroutine ("Move");
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * 3f * Time.deltaTime); 
	}

	IEnumerator Move() {


		while (true) {
			yield return new WaitForSeconds (3.5f);
			transform.eulerAngles += new Vector3 (0, 180f, 0);
		}
	}
}