using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 0.1f;
    public string objName;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;
        if (Input.GetKey("q")) {
            GameObject.Find(objName).SendMessage("Rotate", new Vector3(0, -1, 0));
        }
        if (Input.GetKey("e"))
        {
            GameObject.Find(objName).SendMessage("Rotate", new Vector3(0, 1, 0));
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GameObject.Find(objName).SendMessage("Move", movement);

        //rb.transform.Translate(movement);
    }
}
