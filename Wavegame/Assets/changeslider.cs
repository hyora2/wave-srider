using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeslider : MonoBehaviour {
    public Slider slider;
    private float sinnpuku;


	// Use this for initialization
	void Start () {
        sinnpuku = slider.value;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    float returnValue (){
        sinnpuku = slider.value;
        return sinnpuku;
    }

}
