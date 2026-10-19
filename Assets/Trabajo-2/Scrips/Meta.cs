using UnityEngine;

public class Meta : MonoBehaviour
{
    public ManagerCanvas canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.numen = 4;
            canvas.AbrirMensaje();
        }
    }
}
