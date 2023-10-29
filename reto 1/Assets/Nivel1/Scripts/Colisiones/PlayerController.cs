using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int vidas = 3;
    public Vector3 respawnPosition;
    public TMP_Text vidasUI;
    public GameObject objectToActivate; // El objeto que quieres activar

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            vidas--;
            vidasUI.SetText("X{0}", vidas);
            if (vidas <= 0)
            {
                Destroy(gameObject);
                objectToActivate.SetActive(true); // Activa el objeto
            }
            else
            {
                transform.position = respawnPosition;
            }
        }
    }
}
