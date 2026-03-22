using UnityEngine;

public class gomba : MonoBehaviour
{
    public float velocidad = 1.5f;
    //1 a la derecha y -1 a la izquierda
    private int direction = 1;

    public float izqlimit = -5f;
    public float derlimit = 2f;

    
    void Update()
    {
        //Movimiento horizontal constante
        transform.Translate(Vector2.right * direction * velocidad * Time.deltaTime);

        //Este es el if que cambia la direcciónn en los límites
        if (transform.position.x >= derlimit)
        {
            direction = -1;
            Flip();
        }
        else if (transform.position.x <= izqlimit)
        {
            direction = 1;
            Flip();
        }
        
    }

    // Update is called once per frame
    void Flip()
    {
        //Voltear el gomba
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        
    }
}
