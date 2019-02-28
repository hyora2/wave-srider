using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*単振動の円*/

public class dotmove2 : MonoBehaviour {
	public float sinpuku = 3f;
	public float syuuki = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 pos = Vector2.zero; //中心を決めます。今回は(0,0,0)
		float speed = syuuki;

		//範囲を指定してあげると大きな円、小さな円を実装できます。
		pos.x = 0;
		//pos.x += Mathf.Sin(Time.time * speed) * sinpuku; 
		pos.y += Mathf.Cos(Time.time * speed) * sinpuku;
		transform.position = pos;



	}
}
