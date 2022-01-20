using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject cameraPos;
    private GameObject mainCamera;
    private float timer;
    private GameObject Player;
    [SerializeField] private float speed = 10;
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        if (gameObject.transform.position != cameraPos.transform.position)
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, cameraPos.transform.position, Time.deltaTime * speed);
        }
    }
}
