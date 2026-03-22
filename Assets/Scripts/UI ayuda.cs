using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SalirAyuda : MonoBehaviour
{
    private Button btnSalir; // botón de salir

    void OnEnable()
    {
        // agarramos todo el UI
        var root = GetComponent<UIDocument>().rootVisualElement;

        // buscamos el botón por su nombre
        btnSalir = root.Q<Button>("SalirAyuda");

        
        btnSalir.clicked += VolverAlMenu;
    }

    void OnDisable()
    {
        // quitamos el evento
        btnSalir.clicked -= VolverAlMenu;
    }

    void VolverAlMenu()
    {
        // cambia a la escena Menu
        SceneManager.LoadScene("Menu");
    }
}