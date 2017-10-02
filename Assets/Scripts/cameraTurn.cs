using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTurn : MonoBehaviour {

    public float turnSpeed = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 turnAmount = new Vector3(0, 0, 0);

        float turn = Input.GetAxis("Mouse Y");
        turnAmount.Set(-turn, 0, 0);
        transform.Rotate(turnAmount * turnSpeed);

    }
}
