using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    private DetectorParaSalto estado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<DetectorParaSalto>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        //Esto lo que hace es cambiar el sentido de la animacion dependiendo 
        sr.flipX = rb.linearVelocityX < 0;
        //Maneja la animacion de salto 
        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}
