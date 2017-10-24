using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHSpin : MonoBehaviour {

    public float spin_speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 0, spin_speed * Time.deltaTime);
	}
}
