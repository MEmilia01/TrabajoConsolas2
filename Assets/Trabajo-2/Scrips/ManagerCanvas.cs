using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ManagerCanvas : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject menuopciones;
    [SerializeField] GameObject menucontroles;
    [SerializeField] GameObject hub;
    [SerializeField] GameObject mensaje;

    [Header("Objetos")]
    public UnityEngine.UI.Slider slice;
    public GameObject targetObject;
    [SerializeField] GameObject contboton;
    [SerializeField] GameObject volbotoncon;
    [SerializeField] GameObject volbotonmen;
    [SerializeField] TextMeshProUGUI mensajesadv;
    public bool siono;
    private bool aplicacionEnSegundoPlano;
    public int numen;

    [Header("Script")]
    [SerializeField] ManagerNivel niveldatos;

    void Start()
    {
        numen = 0;
        AbrirMensaje();
    }

    void Update()
    {

    }


    private void SeleccionarBoton(GameObject boton)
    {
        if (boton != null && boton.activeInHierarchy)
        {
            EventSystem.current.SetSelectedGameObject(boton);
            Debug.Log("este es el boton que esta siendo obtenido: " + boton);
        }
    }
    private void OnApplicationPause(bool pausada)
    {
        aplicacionEnSegundoPlano = pausada;

        if (pausada)
        {
            numen = 3;
            AbrirMensaje();
        }
        else { return; }
    }
    public void CambiarMensaje()
    {
        if (siono) { numen = 2; }

        switch (numen)
        {
            case 0:
                mensajesadv.text = "Recorre el camino hasta tu nido, si tienes dudas mira controles." +
                    "La version : " + Application.version;
                break;
            case 1:
                mensajesadv.text = "Se necesita un mando para funcionar";
                break;
            case 2:
                mensajesadv.text = "Muy mal no quieras sobrevivir";
                break;
            case 3:
                mensajesadv.text = "Has dejado el juego en segundo plano";
                break;
            case 4:
                mensajesadv.text = "Has Ganado YEPPIEE!!";
                break;
        }
    }


    //uso de los menus
    public void AbrirHub()
    {
        hub.SetActive(true);
        menucontroles.SetActive(false);
        menuopciones.SetActive(false);
        mensaje.SetActive(false);

        Time.timeScale = 1f;
    }
    public void AbrirMOpciones()
    {
        hub.SetActive(false);
        menucontroles.SetActive(false);
        menuopciones.SetActive(true);
        mensaje.SetActive(false);

        SeleccionarBoton(contboton);
        Time.timeScale = 0f;
    }
    public void AbrirMControles()
    {
        hub.SetActive(false);
        menucontroles.SetActive(true);
        menuopciones.SetActive(false);
        mensaje.SetActive(false);

        SeleccionarBoton(volbotoncon);
    }
    public void AbrirMensaje()
    {
        hub.SetActive(false);
        menucontroles.SetActive(false);
        menuopciones.SetActive(false);
        mensaje.SetActive(true);

        Time.timeScale = 0f;
        CambiarMensaje();
        SeleccionarBoton(volbotonmen);
    }
    public void Reinicio()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
