using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
     public Text  scoreText;
      float score;
     float totalTime = 0;
    int seconds;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        totalTime += Time.deltaTime;
        seconds = (int)totalTime*13;
        scoreText.text = "Score:"+seconds.ToString();
    }

}
