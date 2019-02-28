using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] float enemySpeed = 1;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1, 0) * enemySpeed;
    }

    // Update is called once per frame
    void Update(){

    }
    private void FixedUpdate(){
        rb.velocity = new Vector2(-1, 0) * enemySpeed;

    }

    void OnTriggerEnter2D(Collider2D other){
       
        if (other.gameObject.tag == "EnemyEnd" || other.gameObject.tag == "player"){
            
             Destroy(this.gameObject);
        }
    }

}


　