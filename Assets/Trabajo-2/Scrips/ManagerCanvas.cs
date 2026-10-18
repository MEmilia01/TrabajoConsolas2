using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ManagerCanvas : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject menuopciones;
    [SerializeField] GameObject menucontroles;
    [SerializeField] GameObject hub;

    public Slider slice;

    void Start()
    {

        AbrirHub();
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
    public void Reinicio()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Salir()
    {
        Debug.Log("works");
    }
}
