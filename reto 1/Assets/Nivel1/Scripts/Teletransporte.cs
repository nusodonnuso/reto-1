using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public Transform ObjetoParaTeletransportar;
    public Vector3 nuevaPosicion1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform == ObjetoParaTeletransportar)
        {
            transform.position = nuevaPosicion1;
        }
    }
}
