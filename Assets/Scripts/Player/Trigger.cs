using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private bool isFirst;
    public bool firstTrigger { get { return isFirst; } }

    private void Start()
    {
        if(firstTrigger == true)
        {
            gameObject.SetActive(false);
        }
    }

}
