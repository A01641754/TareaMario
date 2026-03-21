using UnityEngine;

public class DetectorParaSalto : MonoBehaviour
{
public bool estaEnPiso {get; private set;} = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
        print(estaEnPiso);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
        print(estaEnPiso);
    }



}
