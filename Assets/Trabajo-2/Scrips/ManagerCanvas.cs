using UnityEngine;

public class ManagerCanvas : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject menuopciones;
    [SerializeField] GameObject menucontroles;
    [SerializeField] GameObject hub;

    void Start()
    {
        AbrirMControles();
    }

    void Update()
    {
        
    }



    public void AbrirHub()
    {
        hub.SetActive(true);
        menucontroles.SetActive(false);
        menuopciones.SetActive(false);
    }
    public void AbrirMOpciones()
    {
        hub.SetActive(false);
        menucontroles.SetActive(false);
        menuopciones.SetActive(true);
    }
    public void AbrirMControles()
    {
        hub.SetActive(false);
        menucontroles.SetActive(true);
        menuopciones.SetActive(false);
    }
}
