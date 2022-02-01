using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject Player;
    [SerializeField]private Animator animator;
    RaycastHit hit;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if(collision.gameObject.GetComponent<MovementPlayer>() != null)
        {
            Player.transform.GetComponent<MovementPlayer>().BoostBoi();
            animator.SetTrigger("jump");
        }
    }
}
