using UnityEngine;
using UnityEngine.InputSystem;

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

    private void Start()
    {
        transform.position = managerexterno.puntospawn.transform.position;
        numactual = 0f;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

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
        Debug.Log(numactual);
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
