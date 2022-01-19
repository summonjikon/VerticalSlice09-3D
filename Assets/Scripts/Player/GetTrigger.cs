using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
    private bool isTrigger;
    [SerializeField] private GameObject enterTrigger;
    [SerializeField] private GameObject exitTrigger;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Trigger>().firstTrigger == true)
        {
            isTrigger = false;
        }
        else if(collision.gameObject.GetComponent<Trigger>().firstTrigger == false)
        {
            isTrigger = true;
        }
        else
        {
            return;
        }
    }
}