using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour {
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject Life4;
    public GameObject Life5;
    public float PLife;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PLife <=80) {
            Destroy(Life5);
        }
        if (PLife <= 60)
        {
            Destroy(Life4);
        }
        if (PLife <=40)
        {
            Destroy(Life3);
        }
        if (PLife <= 20)
        {
            Destroy(Life2);
        }
        if (PLife <= 0)
        {
            Destroy(Life1);
            SceneLoad();
        }
    }
    public void SceneLoad()
    {
        SceneManager.LoadScene("GameOver");
    }
}
