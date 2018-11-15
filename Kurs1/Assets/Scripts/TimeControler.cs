using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour {
    public float speed;
    public float angularSpeed;
    public GameObject bullet;
    public float shotPower;
    public Transform spawner;
    public GameObject newBullet;
	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical") * Time .deltaTime); // poruszanie ad lewo prawo
        //transform.Translate(Vector3.up * angularSpeed * Input.GetAxis("Horizontal") * Time .deltaTime); //obrót postaci, w rzeczywistosci d góra a dół


       // if(Input.GetKeyDown(KeyCode.Space)) //strzelanie
        //{
        //    newBullet = Instantiate(bullet, spawner.position, transform.rotation);
       //     newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * shotPower);
       // }
 
        
        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * speed);
        //    Debug.Log("is True");
        //}
    }
}
