using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	private Rigidbody rb;
	private GameObject player;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

	// Update is called once per frame - game code
	void Update () {

	}

	// called before physics calculations - physics code
	void FixedUpdate() {

		float rotateX =-1*Input.GetAxis ("Horizontal");
		float rotateZ =-1*Input.GetAxis ("Vertical");

        // Use this to rotate around player point
        Vector3 playerPos = player.transform.position;
        Vector3 worldangle = new Vector3(rotateX, 0.0f, rotateZ);
        rb.transform.RotateAround(playerPos, worldangle, rotationSpeed);

        // Use this to rotate around origin
        //Vector3 rotation = new Vector3 (rotateX, 0, rotateZ);
        //transform.Rotate (rotation);

    }
}
