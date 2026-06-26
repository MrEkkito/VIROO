using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TablonInformacion : MonoBehaviour
{
    [Header("UI")]
    public Image imagen;

    public TMP_Text nombreComun;
    public TMP_Text nombreCientifico;
    public TMP_Text descripcion;

    private void Start()
    {
        Limpiar();
    }

    public void Limpiar()
    {
        if (imagen != null)
            imagen.gameObject.SetActive(false);

        if (nombreComun != null)
            nombreComun.gameObject.SetActive(false);

        if (nombreCientifico != null)
            nombreCientifico.gameObject.SetActive(false);

        if (descripcion != null)
        {
            descripcion.gameObject.SetActive(true);
            descripcion.text = "Selecciona un objeto en la terminal para ver su informacion.";
        }
    }

    public void Mostrar(Elemento elemento)
    {
        if (imagen != null)
        {
            imagen.gameObject.SetActive(true);
            imagen.sprite = elemento.imagen;
        }

        if (nombreComun != null)
        {
            nombreComun.gameObject.SetActive(true);
            nombreComun.text = elemento.nombreComun;
        }

        if (nombreCientifico != null)
        {
            nombreCientifico.gameObject.SetActive(true);
            nombreCientifico.text = elemento.nombreCientifico;
        }

        if (descripcion != null)
        {
            descripcion.gameObject.SetActive(true);
            descripcion.text = elemento.descripcion;
        }
    }
}