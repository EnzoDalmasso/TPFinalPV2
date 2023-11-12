using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    PerfilJugador perfilJugador;
    public PerfilJugador PerfilJugador { get => perfilJugador; }

    public int HpJugador;
    

    private ObjectCollector collector;

    [SerializeField]
    private UnityEvent<string> OnTextChanged;

    //-------------- Eventos del jugador ----------- //
    [SerializeField]
    private UnityEvent<int> OnlivesChanged;

    private void Start()
    {
        HpJugador = perfilJugador.Vida;
        OnlivesChanged.Invoke(perfilJugador.Vida);
        collector = GetComponent<ObjectCollector>();
        OnTextChanged.Invoke(GameManager.Instance.GetScore().ToString());
    }

    public void ModificarVida(int puntos)
    {
        HpJugador += puntos;
        GameManager.Instance.AddScore(puntos * 1);
        OnTextChanged.Invoke(GameManager.Instance.GetScore().ToString());
        OnlivesChanged.Invoke(HpJugador);
        Debug.Log(EstasVivo());
    }


    private bool EstasVivo()
    {

        return HpJugador > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta") && collector.CollectedCount<3) { return; }

        Debug.Log("GANASTE");
    }
}