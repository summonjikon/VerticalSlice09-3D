using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController controllerP;
    public Vector3 playerSpeed;
    public bool groundedPlayer = true;
    public float gravityAmount = -9.81f;
    public float jumpBoost = 600f;
    private float _playerMoveSpeed = 2.0f;
    private bool justBoosted;
    private float boostTimer;
    RaycastHit hit;
    public LayerMask layerMask;

    private Animator anim;

    private void Start()
    {
        controllerP = gameObject.GetComponent<CharacterController>();

        anim = GetComponent<Animator>();
    }

    void Update()
    {
        playerSpeed.y += gravityAmount * Time.deltaTime;
        controllerP.Move(playerSpeed * Time.deltaTime);

        if(justBoosted == true)
        {
            boostTimer += Time.deltaTime;
            if(boostTimer >= 2f)
            {
                boostTimer = 0;
                justBoosted = false;
            }
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.265f, layerMask))
        {
            groundedPlayer = true;
        }
        else
        {
            groundedPlayer = false;
        }

        if (groundedPlayer == true)
        {
            playerSpeed.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controllerP.Move(move * Time.deltaTime * _playerMoveSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }

    public void BoostBoi()
    {
        if(justBoosted == false)
        {
            playerSpeed.y += Mathf.Sqrt(jumpBoost * -1.0f * gravityAmount);
            justBoosted = true;
            anim.SetTrigger("Jumped");
        }
        else
        {
            return;
        }
    }
}
