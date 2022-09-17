using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

public int points=10;
Rigidbody targetRb;


GameManager engine;

    // Start is called before the first frame update
    void Start()
    {

engine=GameObject.Find("gm").GetComponent<GameManager>();

        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up* Random.Range(12,16), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10,10),Random.Range(-10,10),Random.Range(-10,10),ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4),0,-6);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    private void OnMouseDown(){
        engine.UpdateScore(points);
        Destroy(gameObject);

    }


    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
    }
}
