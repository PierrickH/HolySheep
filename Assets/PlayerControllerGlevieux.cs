/*using UnityEngine;
using System.Collections;

public class PlayerControllerGlevieux : MonoBehaviour {

	private bool canJump = true;
	private bool jumping = false;
	private Transform head;

	// Use this for initialization
	void Start () {
		head = transform.Find();	
	}
}
	
	// Update is called once per frame
//	void Update () {
	
//	}

	// Modifs physiques
    //	void FixedUpdate()
    //	{
	//	Vector3 direction = new Vector3 ();
    // }
*/
using UnityEngine;
using System.Collections;

public class PlayerControllerGlevieux : MonoBehaviour {

	private bool canJump = true;
	private bool jumping = false;

	private float horizontal, vertical;
	public float turnSpeed = 1f;
	public float moveSpeed = 10f;

	private Rigidbody _body;

	// Use this for initialization
	void Start () {
		_body = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {

	}

	// Modifs physiques
	void FixedUpdate()
	{
		horizontal = Input.GetAxis("Horizontal") * turnSpeed;
		vertical = Input.GetAxis ("Vertical") * moveSpeed;

		_body.AddRelativeForce(new Vector3(vertical, 0, 0));
		_body.AddTorque (new Vector3 (0, horizontal, 0));

		/*direction = new Vector3();
		direction += Input.GetAxis("Horizontal") * Camera.main.transform.right;
		direction += Input.GetAxis("Vertical") * Camera.main.transform.forward;
		direction.y = 0;

		Vector3 newVelocity = direction * 10;
		newVelocity.y = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = newVelocity;
		transform.LookAt(transform.position + direction);
		GetComponent<Rigidbody>().angularVelocity = new Vector3();

		Vector3 dirGaze = Camera.main.transform.forward;
		dirGaze.y = 0;
		*/

		if (Input.GetButtonDown("Jump") && canJump)
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
			canJump = false;
			jumping = true;
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.contacts[0].normal.y > 0.3f)
			canJump = true;   
	}
}
