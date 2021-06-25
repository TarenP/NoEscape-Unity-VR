using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public GameObject player;
    public float speed = 0.6f;
    bool foundPlayer = false;
    public float agro = 10;
    public float dr = 7f;

    private void Start()
    {
        player = GameObject.Find("Player");

        if ((transform.position - player.transform.position).magnitude < dr)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        /*if ((transform.position - player.transform.position).magnitude < agro)
        {
            foundPlayer = true
        }
        */
        

        if ((transform.position - player.transform.position).magnitude < agro)
        {
            transform.LookAt(player.transform);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

 

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            transform.Rotate(0, Random.Range(5, 180), 0);
        }
    }




}