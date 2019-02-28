using UnityEngine;

public class ProduceEnemy : MonoBehaviour
{

    int number;
    float time = 0f;
    float allTime  = 0f;
    float producewhile = 4f;
    [SerializeField] float producePosition = 10f;
    public GameObject[] Type;
    // Use this for initialization
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }

    private void FixedUpdate(){
        Clock();
        if (time > producewhile){
            Produce();
            time = 0f;
        }
    }


    void Produce(){
        number = Random.Range( 0, Type.Length);
        Instantiate( Type[number],new Vector2(producePosition,Random.Range(-4.5f, 5.5f)), transform.rotation);
    }

    void Clock(){
        allTime += Time.deltaTime;
        time += Time.deltaTime;
        if(allTime > 10f){
            producewhile = producewhile * 0.9f;
            allTime = 0;
        }
    }

}

