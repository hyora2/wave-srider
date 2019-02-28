using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotMove : MonoBehaviour {
  
	Vector2 pos;
    GameObject wavechange;
    GameObject wavecont;

    private float hatyou = 0, sinpuku = 0, syuuki = 0;

	// Use this for initialization
	void Start () {
        wavechange = GameObject.FindWithTag("wavechange");
        wavecont = GameObject.FindWithTag("wavepoint");
      
        sinpuku = wavecont.GetComponent<wavecontrol>().get_A();
        hatyou = wavecont.GetComponent<wavecontrol>().get_RAM();
        syuuki = wavecont.GetComponent<wavecontrol>().get_T();

		pos.x = transform.position.x;

	}
	
	void Update () {

        //setterhatyou (ram);

        sinpuku = wavechange.GetComponent<changeslider>().slider.value;
        hatyou = wavecont.GetComponent<wavecontrol>().get_RAM();

		pos.y = tansindou_enn (syuuki, sinpuku, hatyou);

		transform.position = pos;
	}


	float tansindou_enn (float Tsyuki, float Asinpuku , float Rhatyou){

		Vector2 iti = Vector2.zero; //中心を決めます。今回は(0,0,0)
		float speed = Tsyuki;
		float nfaiw;
		float ram_x = pos.x;

		if (Rhatyou <= 0) {
			Debug.Log ("error");
			return 999;
		}
		nfaiw = (ram_x / Rhatyou ) * Mathf.PI;//

		//範囲を指定してあげると大きな円、小さな円を実装できます。
		//iti.x += Mathf.Sin(Time.time * speed) * sinpuku; 
		iti.y += Mathf.Cos((Time.time * speed) - nfaiw) * Asinpuku;

		return iti.y;

	}

}
