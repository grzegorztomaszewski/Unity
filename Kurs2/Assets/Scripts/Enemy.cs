using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    public int HP;
    public NavMeshAgent agent;
    public GameObject player;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<TimeControler>().gameObject;
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(HP <=0)
        {
            Destroy(this.gameObject);

            agent.destination = player.transform.position;
        }
	}
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);  //NISZCZENIE OBIEKTU
            HP = HP-1;                      //ZMNIEJSZANIE HP 
            Debug.Log("HP= " + HP);           //Debug, sprawdzenie
        }
    }
}
