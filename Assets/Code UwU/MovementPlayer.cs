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
    RaycastHit hit;
    public LayerMask layerMask;

    private void Start()
    {
        controllerP = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        playerSpeed.y += gravityAmount * Time.deltaTime;
        controllerP.Move(playerSpeed * Time.deltaTime);


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
        }
    }

    public void BoostBoi()
    {
        playerSpeed.y += Mathf.Sqrt(jumpBoost * -1.0f * gravityAmount);
    }
}
