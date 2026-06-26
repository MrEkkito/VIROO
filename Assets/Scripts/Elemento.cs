using UnityEngine;

[System.Serializable]
public class Elemento
{
    [Header("Nombre del botón")]
    public string nombre;

    [Header("Información")]
    public string nombreComun;
    public string nombreCientifico;

    [TextArea(4, 10)]
    public string descripcion;

    public Sprite imagen;

    [Header("Prefab")]
    public GameObject prefab;
}