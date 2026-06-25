using UnityEngine;

[System.Serializable]
public class Elemento
{
    public string nombre;
    public GameObject prefab;
    [TextArea(3, 10)]
    public string descripcion;
}