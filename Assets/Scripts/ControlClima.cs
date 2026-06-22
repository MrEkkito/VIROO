using UnityEngine;

public class ControlClima : MonoBehaviour
{
    [Header("Skybox")]
    public Material cieloDia;
    public Material cieloNoche;
    public Material cieloLluviaNoche;
    public Material cieloLluviaDespejada;
    public Material cieloLluvia;
    public Material cieloLluviaTorrencial;
    public Material cieloSpace;
    public Material cieloAnochecer;

    [Header("Lluvia")]
    public GameObject prefabLluvia;

    private GameObject lluviaInstanciada;

    [Header("Audio")]
    public AudioSource audioAmbiente;

    public AudioClip sonidoDia;
    public AudioClip sonidoNoche;
    public AudioClip sonidoLluvia;
    public AudioClip sonidoTormenta;
    public AudioClip sonidoSpace;
    public AudioClip sonidoAnochecer;

    [Header("Luz")]
    public Light luzDireccional;

    private void AplicarClima(
        Material skybox,
        AudioClip sonido,
        bool lluviaActiva,
        float intensidadLuz)
    {
        RenderSettings.skybox = skybox;

        if (audioAmbiente != null && sonido != null)
        {
            if (audioAmbiente.clip != sonido)
            {
                audioAmbiente.clip = sonido;
                audioAmbiente.loop = true;
                audioAmbiente.Play();
            }
        }

        if (lluviaActiva)
        {
            if (lluviaInstanciada == null && prefabLluvia != null)
            {
                lluviaInstanciada = Instantiate(
                    prefabLluvia,
                    new Vector3(-5f, 20f, 0f),
                    Quaternion.Euler(-90f, 0f, 0f)

                );
            }
        }
        else
        {
            if (lluviaInstanciada != null)
            {
                Destroy(lluviaInstanciada);
                lluviaInstanciada = null;
            }
        }

        if (luzDireccional != null)
        {
            luzDireccional.intensity = intensidadLuz;
        }

        DynamicGI.UpdateEnvironment();
    }

    public void CambiarADia()
    {
        AplicarClima(
            cieloDia,
            sonidoDia,
            false,
            1.2f
        );
    }

    public void CambiarANoche()
    {
        AplicarClima(
            cieloNoche,
            sonidoNoche,
            false,
            0.2f
        );
    }

    public void CambiarALluviaNoche()
    {
        AplicarClima(
            cieloLluviaNoche,
            sonidoTormenta,
            true,
            0.15f
        );
    }

    public void CambiarALluviaDespejada()
    {
        AplicarClima(
            cieloLluviaDespejada,
            sonidoLluvia,
            true,
            0.8f
        );
    }

    public void CambiarALluvia()
    {
        AplicarClima(
            cieloLluvia,
            sonidoLluvia,
            true,
            0.5f
        );
    }

    public void CambiarALluviaTorrencial()
    {
        AplicarClima(
            cieloLluviaTorrencial,
            sonidoTormenta,
            true,
            0.3f
        );
    }

    public void CambiarASpace()
    {
        AplicarClima(
            cieloSpace,
            sonidoSpace,
            false,
            0.7f
        );
    }

    public void CambiarAAnochecer()
    {
        AplicarClima(
            cieloAnochecer,
            sonidoAnochecer,
            false,
            0.4f
        );
    }
}