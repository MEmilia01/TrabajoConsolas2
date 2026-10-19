using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Player : MonoBehaviour
{
    [Header("Datos personaje")]
    [SerializeField] float speed = 20f;
    public float numactual;

    [Header("Scripts y demas")]
    [SerializeField] ManagerNivel managerexterno;
    [SerializeField] ManagerCanvas canvas;
    [SerializeField] private PlayerInput playerInput;

    [Header("Extras")]
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    [SerializeField] Vector2 moveInput;
    [SerializeField] GameObject fuego;

    private void Start()
    {
        transform.position = managerexterno.puntospawn.transform.position;
        numactual = 0f;
        fuego.SetActive(false);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();

        //ignora la gravedad.
        rb.gravityScale = 0f;
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnMenus(InputValue value)
    {
        canvas.AbrirMOpciones();
    }
    public void OnAtaque(InputValue value)
    {
        StartCoroutine(FuegoActivo());
    }

    private void ActualizarSprite()
    {
        if (moveInput.x > 0.01f)
        {
            sprite.flipX = true;
            numactual++;
        }
        else if (moveInput.x < -0.01f)
        {
            sprite.flipX = false;
            numactual--;
        }
    }
    IEnumerator FuegoActivo()
    {
        fuego.SetActive(true);

        yield return new WaitForSeconds(2f);
        fuego.SetActive(false);        
    }

    private void FixedUpdate()
    {
        Vector2 targetVelocity = moveInput * speed;

        rb.linearVelocity = targetVelocity;

        if(numactual < managerexterno.inicionum) {  numactual = managerexterno.inicionum; }
        else if (numactual > managerexterno.finalnum) { numactual = managerexterno.finalnum; }

        ActualizarSprite();
    }
}
