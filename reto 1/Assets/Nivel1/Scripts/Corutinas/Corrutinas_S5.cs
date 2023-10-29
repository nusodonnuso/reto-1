using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas_S5 : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("CambiarColor");
    }
    IEnumerator CambiarColor()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.magenta;
    }

}
