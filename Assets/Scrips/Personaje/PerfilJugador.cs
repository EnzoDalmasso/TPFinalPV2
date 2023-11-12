using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PerfilJugador : ScriptableObject
{
    //SALTO

    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] private float fuerzaSalto = 5f;
    public float FuerzaSalto { get => fuerzaSalto; set => fuerzaSalto = value; }

    [SerializeField] private AudioClip jumpSFX;

    public AudioClip JumpSFX { get => jumpSFX; set => jumpSFX = value; }

    [SerializeField] private AudioClip collisionSFX;
    public AudioClip CollisionSFX { get => collisionSFX; set => collisionSFX = value; }
    

    //MOVERJUGADOR
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] float velocidad = 5f;
    public float Velocidad { get => velocidad; set => velocidad = value; }
   

    // Variables de uso interno en el script
    private float moverHorizontal;
    public float MoverHorizontal { get => moverHorizontal; set => moverHorizontal = value; }
    

    private Vector2 direccion;
    public Vector2 Direccion { get => direccion; set => direccion = value; }
    

    //JUGADOR
    [SerializeField] private int vida = 1;
    public int Vida { get => vida; set => vida = value; }
}
