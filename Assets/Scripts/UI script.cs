using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private Button btnJugar;
    private Button btnAyuda;
    private Button btnCreditos;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        btnJugar = root.Q<Button>("Jugar");
        btnAyuda = root.Q<Button>("Ayuda");
        btnCreditos = root.Q<Button>("Creditos");

        // Eventos de click
        btnJugar.clicked += IrAJuego;
        btnAyuda.clicked += IrAAyuda;
        btnCreditos.clicked += IrACreditos;
    }

    void IrAJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void IrAAyuda()
    {
        SceneManager.LoadScene("Ayudas");
    }

    void IrACreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}