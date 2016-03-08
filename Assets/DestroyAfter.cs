using UnityEngine;
using System.Collections;

public class DestroyAfter : MonoBehaviour {

	public float destroyAfter;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyAfter);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
