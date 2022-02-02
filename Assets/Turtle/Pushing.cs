using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour
{
    [SerializeField] private Transform First;
    [SerializeField] private Transform Second;
    [SerializeField] private Transform Third;
    [SerializeField] private Transform Fourth;
    [SerializeField] private Transform Fifth;
    [SerializeField] private Transform Sixth;
    public float speed = 2;
    public bool isFirst = false;
    public bool isSec = false;
    public bool isThird = false;
    public bool isFourth = false;
    public bool isFifth = false;

    private void Start()
    {
        transform.position = First.position;
    }

    void Update()
    {
        if (transform.position.x >= 12.9 && transform.position.x <= 13.1)
        {
            isFourth = false;
            isFifth = true;
            isFirst = false;
        }

        if (isFirst)
            transform.position = Vector3.Lerp(transform.position, Second.position, Time.deltaTime * speed);

        if (isSec)
            transform.position = Vector3.Lerp(transform.position, Third.position, Time.deltaTime * speed);

        if (isThird)
            transform.position = Vector3.Lerp(transform.position, Fourth.position, Time.deltaTime * speed);

        if (isFourth)
            transform.position = Vector3.Lerp(transform.position, Fifth.position, Time.deltaTime * speed);

        if (isFifth)
            transform.position = Vector3.Lerp(transform.position, Sixth.position, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider Other)
    {
        if (transform.position.z >= -82.5)
        {
            isFirst = true;
        }
        if (transform.position.z <= -74.5 && transform.position.z >= -75.5)
        {
            isFirst = false;
            isSec = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if (transform.position.z <= -67.5 && transform.position.z >= -68.5)
        {
            isSec = false;
            isThird = true;
            isFirst = false;
        }
        if (transform.position.x >= 18.5 && transform.position.x <= 19.5)
        {
            isThird = false;
            isFourth = true;
            isFirst = false;
        }
    }



}
