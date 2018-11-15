using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    public float speed;
    public float angularSpeed;
    public float rotation_speed;
    public float speed_barrel;
    public GameObject bullet;
    public float shotPower;
    public Transform spawner;
    public GameObject newBullet;

    void Start()
    {

    }

    void Update()
    {
       transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime); // poruszanie przód tył
       transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime); //poruszanie lewo prawo

     // RUCHY ROTACYJNE(Q&E)
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * angularSpeed);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.down * angularSpeed);

        //RUCHY ROTACYJNE TOWER'A (J&L)
        if (Input.GetKey(KeyCode.L))
            transform.Rotate(Vector3.up * rotation_speed);
        if (Input.GetKey(KeyCode.J))
            transform.Rotate(Vector3.down * rotation_speed);

        //RUCHY PIONOWE BARREL'A (I&K)
        if (Input.GetKey(KeyCode.I))
            transform.Rotate(Vector3.left * speed_barrel);
        if (Input.GetKey(KeyCode.K))
            transform.Rotate(Vector3.right * speed_barrel);

        //STRZELANIE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newBullet = Instantiate(bullet, spawner.position, spawner.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawner.transform.forward * shotPower);
        }

        // TEST DZIAŁANIA
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * speed);
        //    Debug.Log("is True");
        //}


        /*
        // RUCHY PRZÓD, TYŁ, LEWO, PRAWO

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed);
         */
    }
}
