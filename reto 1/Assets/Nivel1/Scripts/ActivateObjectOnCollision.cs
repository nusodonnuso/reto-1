using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjectOnCollision : MonoBehaviour
{
    public GameObject objectToActivate;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectToActivate.SetActive(true);
        }
    }
}