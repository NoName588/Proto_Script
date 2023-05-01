using UnityEngine;

public class Colisionador : MonoBehaviour
{
    public int nivelDePoder;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hola");
        }
    }
}



