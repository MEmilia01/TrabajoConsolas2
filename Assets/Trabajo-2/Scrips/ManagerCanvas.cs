using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerCanvas : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject menuopciones;
    [SerializeField] GameObject menucontroles;
    [SerializeField] GameObject hub;
    [SerializeField] GameObject mensaje;

    public UnityEngine.UI.Slider slice;
    public GameObject targetObject;

    public ManagerNivel niveldatos;

    void Start()
    {
        ActSlice();
        AbrirHub();
    }

    void Update()
    {
        
    }


    public void ActSlice()
    {
        if (slice == null) { Debug.Log("Falta la slice"); return; }
        else
        {
            slice.onValueChanged.AddListener(OnSliderValueChanged);
            slice.minValue = niveldatos.inicionum;
            slice.maxValue = niveldatos.finalnum;
            
            //inicio de partida
            slice.value = niveldatos.inicionum;
        }
    }
    void OnSliderValueChanged(float value)
    {
        // Escalar el objeto según el valor del Slider
        float newScale = Mathf.Lerp(niveldatos.inicionum, niveldatos.finalnum, value);
    }


    //uso de los menus
    public void AbrirHub()
    {
        hub.SetActive(true);
        menucontroles.SetActive(false);
        menuopciones.SetActive(false);
        mensaje.SetActive(false);
    }
    public void AbrirMOpciones()
    {
        hub.SetActive(false);
        menucontroles.SetActive(false);
        menuopciones.SetActive(true);
        mensaje.SetActive(false);
    }
    public void AbrirMControles()
    {
        hub.SetActive(false);
        menucontroles.SetActive(true);
        menuopciones.SetActive(false);
        mensaje.SetActive(false);
    }
    public void AbrirMensaje()
    {
        hub.SetActive(false);
        menucontroles.SetActive(false);
        menuopciones.SetActive(false);
        mensaje.SetActive(true);
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
