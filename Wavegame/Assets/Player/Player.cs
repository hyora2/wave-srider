using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private Rigidbody2D ribo;

     float timeint;
     bool jamp=false;

    //ドットの位置
    dotMove dp;
    public GameObject dot;
    public float JumpPower;
    bool down=false;
    public float rotctl = 1;
    private RaycastHit hit;
    //プレイヤーの上部コリジョン
    public GameObject head;

    public GameObject stand;
    public GameObject Down;

    Vector2 pos;
    Vector2 headpos;
    Vector2 dpos;
    Vector2 fpos;
    float sa;


    public GameObject lifo;
   
    GameObject wavecont;
    GameObject wavechange;

    public float timei;

    private float R = 0, A = 0, T = 0;

    GameObject lifePoint;
    int Key = 0;

    public int lifep = 100;

    float moveSpead = 10f;

    Life life;
    // Use this for initialization
    void Start()
    {

        lifo = GameObject.Find("Life");


        wavecont = GameObject.FindWithTag("wavepoint");
        wavechange = GameObject.FindWithTag("wavechange");



        A = wavecont.GetComponent<wavecontrol>().get_A();
        R = wavecont.GetComponent<wavecontrol>().get_RAM();
        T = wavecont.GetComponent<wavecontrol>().get_T();


        dp = GetComponent<dotMove>();
        //headpos = head.transform.position;
        dpos = dot.transform.position;
        pos = transform.position;
        fpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        A = wavechange.GetComponent<changeslider>().slider.value;
        R = wavecont.GetComponent<wavecontrol>().get_RAM();

        if((Input.GetAxisRaw("Horizontal")) != 0){
            float x = Input.GetAxisRaw("Horizontal");

            pos.x += ((x * moveSpead * Time.deltaTime) / 2);
        }

        playerposition(T, A, R);



        SetDown();
        pos = transform.position;
        //高さによる回転
        sa = fpos.y - transform.position.y;
        transform.rotation = Quaternion.Euler(0, 0, sa * rotctl);

       // transform.Rotate(new Vector3(0, 0, sa * rotctl));
        life = GetComponent<Life>();
        //  lifePoint.GetComponent<Life>();
        if(timei > 0){
            timei -= Time.deltaTime;
        }
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wave")
        {
            Jump();
            //if (Physics.Linecast(transform.position, new Vector2(transform.position.x, transform.position.y -0.46f), out hit, LayerMask.GetMask("Wave"))) {

            Debug.Log("Ontriger");
            //ドットの位置
            dpos = other.transform.position;
             //プレイヤー頭部の位置
            headpos = head.transform.position;
            //プレイヤーの位置
            if (jamp == false)
            {
                pos.y = dpos.y + 0.75f;
                transform.position = new Vector2(pos.x, pos.y);

            }
            //しゃがみ
            if (down == true)
            {
                headpos.y = pos.y;
                head.transform.position = new Vector2(headpos.x, headpos.y);
            }
            else
            {
                headpos.y = pos.y + 0.2f;
                head.transform.position = new Vector2(headpos.x, headpos.y);
            }
           

        }
    }



    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jamp = true;
            ribo.AddForce(Vector2.up * JumpPower);
            jamp = false;
        }
    }
    private void SetDown()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            down = true;
            stand.SetActive(false);
            Down.SetActive(true);

        }
        else
        {
            down = false;
            Down.SetActive(false);
            stand.SetActive(true);
        }
    }

    void playerposition(float T, float A, float R){
      //  pos.x = x;
        pos.y = tansindou_enn(T, A, R);
        transform.position = pos;

    }



	private void OnTriggerEnter2D(Collider2D other)
	{
        if (timei <= 0)
        {
            //ダメージ
            if (other.gameObject.tag == "Enemy")
            {
                Life life = lifo.GetComponent<Life>();
                life.PLife -= 20;
                timei = 2f;

            }

        }
	}



	

    float tansindou_enn(float Tsyuki, float Asinpuku, float Rhatyou)
    {

        Vector2 iti = Vector2.zero; //中心を決めます。今回は(0,0,0)
        float speed = Tsyuki;
        float nfaiw;
        float ram_x = pos.x;

        if (Rhatyou <= 0)
        {
            Debug.Log("error");
            return 999;
        }
        nfaiw = (ram_x / Rhatyou) * Mathf.PI;//

        //範囲を指定してあげると大きな円、小さな円を実装できます。
        //iti.x += Mathf.Sin(Time.time * speed) * sinpuku; 
        iti.y += Mathf.Cos((Time.time * speed) - nfaiw) * Asinpuku;

        return iti.y + 0.80f;

    }


}
