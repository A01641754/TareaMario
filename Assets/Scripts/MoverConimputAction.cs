using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConimputAction : MonoBehaviour
{
    [SerializeField]
    private InputAction AccionMover;

    [SerializeField]
    private InputAction AccionSalto;

    private Rigidbody2D rb;

    private DetectorParaSalto estado;

    private float VelocidadX = 7f;
    private float VelocidadY = 7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AccionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<DetectorParaSalto>();
    }

    void OnEnable()
    {
        AccionSalto.Enable(); // Inecesario lol
        AccionSalto.performed += saltar;
    }

    void OnDisable()
    {
        AccionSalto.Disable();
        AccionSalto.performed -= saltar;
    }

    public void saltar(InputAction.CallbackContext context)
    {
            rb.linearVelocityY = VelocidadY;

    }


    void Update()
    {
        Vector2 Movimiento = AccionMover. ReadValue<Vector2>();
        //transform.position = (Vector2)transform.position + Time.deltaTime * VelocidadX * Movimiento;
        rb.linearVelocityX = VelocidadX * Movimiento.x;
    }
}