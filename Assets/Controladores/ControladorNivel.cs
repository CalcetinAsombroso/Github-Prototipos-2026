using UnityEngine;

public class ControladorNivel : MonoBehaviour
{
    public ControladorOla controladorOla;
    public float contadorDeTiempo;

    private float tiempoInicioGameplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tiempoInicioGameplay = Time.time;   
    }

    // Update is called once per frame
    void Update()
    {
        contadorDeTiempo = Time.time - tiempoInicioGameplay;
        controladorOla.UpdateTime(contadorDeTiempo);
    }
}
