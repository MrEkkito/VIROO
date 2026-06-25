using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject objetoActual;

    public float alturaOffset = 1.5f;

    public void Spawnear(GameObject prefab)
    {
        if (objetoActual != null)
        {
            Destroy(objetoActual);
        }

        Vector3 posicionSpawn = transform.position + transform.up * alturaOffset;

        objetoActual = Instantiate(
            prefab,
            posicionSpawn,
            transform.rotation
        );
    }
}