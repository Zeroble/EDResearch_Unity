using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody my_rb;
    public float speed = 0.1f;
    public float jumpSpace = 300f;

	void Start () {
        my_rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.A))
            this.gameObject.transform.Translate(new Vector3(-speed,0,0));
        if (Input.GetKeyDown(KeyCode.Space))
            my_rb.AddForce(new Vector3(0,jumpSpace,0));
        if (Input.GetKey(KeyCode.S))
            this.gameObject.transform.Translate(new Vector3(0, -speed, 0));
        if (Input.GetKey(KeyCode.D))
            this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
        //getKey 계속받는다 //getKeyDown 한번만 받는다
    }
}
