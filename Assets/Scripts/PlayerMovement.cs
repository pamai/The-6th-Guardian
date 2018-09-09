using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void Move(Vector3 movement) {
        rb.transform.Translate(movement);
    }

    void Rotate(Vector3 rotate) {
        Vector3 ang = Vector3.Scale(rotate, new Vector3(5, 5, 5));
        rb.transform.Rotate(ang);
    }
}
