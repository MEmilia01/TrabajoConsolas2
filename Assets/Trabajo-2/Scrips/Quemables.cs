using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Quemables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FUEGO"))
        {
            Destroy (this.gameObject);
        }
    }
}
