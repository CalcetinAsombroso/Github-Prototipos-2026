using UnityEngine;

public class ControladorOla : MonoBehaviour
{
    public int nivelDificultad;
    public float tiempoParaAumentarDificultad = 10f;

    public void UpdateTime(float newTime)
    {
        if (newTime / tiempoParaAumentarDificultad > nivelDificultad)
        {
            nivelDificultad++;
            Debug.Log("Aumenta dificultad!");
            UpdateDificultad();
        }
    }

    private void UpdateDificultad()
    {

    }
}
