using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TerminalSelector : MonoBehaviour
{
    [Header("Botones")]
    public Transform contenedorBotones;
    public GameObject botonPrefab;

    [Header("Spawners")]
    public List<Spawner> spawners = new List<Spawner>();

    [Header("Elementos disponibles")]
    public List<Elemento> elementos = new List<Elemento>();

    [Header("Tablones donde mostrar la información")]
    public List<TablonInformacion> tablones = new List<TablonInformacion>();

    private void Start()
    {
        CrearBotones();
    }

    private void CrearBotones()
    {
        foreach (Transform hijo in contenedorBotones)
        {
            Destroy(hijo.gameObject);
        }

        foreach (Elemento elemento in elementos)
        {
            GameObject boton = Instantiate(botonPrefab, contenedorBotones);

            TMP_Text texto = boton.GetComponentInChildren<TMP_Text>();
            if (texto != null)
                texto.text = elemento.nombre;

            Button button = boton.GetComponent<Button>();

            button.onClick.AddListener(() =>
            {
                foreach (Spawner spawner in spawners)
                {
                    if (spawner != null)
                        spawner.Spawnear(elemento.prefab);
                }

                foreach (TablonInformacion tablon in tablones)
                {
                    if (tablon != null)
                        tablon.Mostrar(elemento);
                }
            });
        }
    }
}