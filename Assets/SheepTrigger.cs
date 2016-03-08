using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheepTrigger : MonoBehaviour {

	public GameObject winText;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		if (col.tag == "LittleSheep") {
			winText.SetActive (true);
		}
	}
}