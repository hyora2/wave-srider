using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWave : MonoBehaviour {
	public GameObject dot;
    public int dotcreate = 25;
	// Use this for initialization
	void Start () {

        for(float i = 0; i < dotcreate; ){
			Instantiate (dot, new Vector3 (i, 0f, 0), Quaternion.identity);
			i += 0.1f;
			}
	}
	
}
