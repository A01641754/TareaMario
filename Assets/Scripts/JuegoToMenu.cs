using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    private Button btnVolver; // botón para regresar

    void OnEnable()
    {
        // agarramos el UI
        var root = GetComponent<UIDocument>().rootVisualElement;

        
        btnVolver = root.Q<Button>("VolverMenu");

        
        btnVolver.clicked += IrAlMenu;
    }

    void OnDisable()
    {
        // quitamos el evento
        btnVolver.clicked -= IrAlMenu;
    }

    void IrAlMenu()
    {
        // carga la escena del menú
        SceneManager.LoadScene("Menu");
    }
}