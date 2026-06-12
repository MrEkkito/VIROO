using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Progreso")]
    public int completedPuzzles = 0;

    [Header("Configuración")]
    public int totalPuzzles = 4;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PuzzleCompleted()
    {
        completedPuzzles++;

        Debug.Log("Puzzle completado. Total: " + completedPuzzles);

        if (completedPuzzles >= totalPuzzles)
        {
            ActivateFinalAltar();
        }
    }

    private void ActivateFinalAltar()
    {
        Debug.Log("ALTAR DEL MONARCA DESBLOQUEADO");
    }
}