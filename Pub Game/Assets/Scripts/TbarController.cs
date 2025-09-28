using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TbarController : MonoBehaviour
{
   public GameObject prompt;

    private void Start()
    {
        prompt.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        { 
            prompt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        prompt.SetActive(false);
    }
}
