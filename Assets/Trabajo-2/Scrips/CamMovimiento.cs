using UnityEngine;

public class CamMovimiento : MonoBehaviour
{
    [Header("Seguimiento jugador")]
    public Transform player;          
    public float movvelocidad = 0.125f; 
    public Vector3 eje;           

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + eje;
        desiredPosition.z = transform.position.z;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, movvelocidad);
        transform.position = smoothedPosition;
    }
}
