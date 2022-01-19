using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject cameraPos;
    private float timer;
    void Start()
    {
        cameraPos = GameObject.FindGameObjectWithTag("CameraPos");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 0.1)
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, cameraPos.transform.position, Time.deltaTime);
            timer = 0;
        }
    }
}
