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
        slice.onValueChanged.AddListener(OnSliderValueChanged);
        
    }

    public void ActSlice()
    {
        if (slice == null) { Debug.Log("Falta la slice"); return; }
        else
        {
            slice.minValue = niveldatos.inicionum;
            slice.maxValue = niveldatos.finalnum;
            slice.value = niveldatos.inicionum;
        }
    }
    void OnSliderValueChanged(float value)
    {
        // Escalar el objeto según el valor del Slider
        float newScale = Mathf.Lerp(niveldatos.inicionum, niveldatos.finalnum, value);
        targetObject.transform.localScale = new Vector3(newScale, newScale, newScale);

    }


    //uso de los menus
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
