using UnityEngine;

public class Meta : MonoBehaviour
{
    public ManagerCanvas canvas;

    private void OnTriggerEnter(Collider other)
    {
        canvas.AbrirMensaje();
        canvas.numen = 3;
    }
}
