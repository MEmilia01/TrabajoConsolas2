using UnityEngine;

public class Meta : MonoBehaviour
{
    public ManagerCanvas canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            canvas.numen = 4;
            Debug.Log("llegado");
            canvas.AbrirMensaje();
        }
    }
}
