using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject Player;
    //public float jumpBoost = 600f;
    RaycastHit hit;

    private void Start()
    {
        //Player = gameObject.GetComponent<CharacterController>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, 0.15f))
        {
            Debug.Log("zwartjoekel");
            hit.transform.GetComponent<MovementPlayer>().BoostBoi();
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if(collision.gameObject.GetComponent<MovementPlayer>() != null)
        {
            collision.transform.GetComponent<MovementPlayer>().BoostBoi();
        }
    }
}
