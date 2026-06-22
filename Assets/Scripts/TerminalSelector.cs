using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TerminalSelector : MonoBehaviour
{
    public Transform contenedorBotones;
    public GameObject botonPrefab;

    public List<Spawner> spawners;
    public List<Elemento> elementos;

    private void Start()
    {
        CrearBotones();
    }

    private void CrearBotones()
    {
        foreach (Elemento elemento in elementos)
        {
            GameObject boton = Instantiate(botonPrefab, contenedorBotones);

            boton.GetComponentInChildren<TMP_Text>().text = elemento.nombre;

            boton.GetComponent<Button>().onClick.AddListener(() =>
            {
                foreach (Spawner spawner in spawners)
                {
                    spawner.Spawnear(elemento.prefab);
                }
            });
        }
    }
}