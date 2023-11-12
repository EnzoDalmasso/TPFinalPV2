using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoIA : MonoBehaviour
{
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] float velocidad = 5f;

    // Referencia al transform del jugador serializada
    [SerializeField] Transform jugador;

    // Variable para referenciar otro componente del objeto
    private Rigidbody2D miRigidbody2D;
    private Vector2 direccion;

    // Variable para referenciar otro componente del objeto
    private Animator miAnimator;
    private SpriteRenderer miSprite;

    private void Awake()
    {
        miRigidbody2D = GetComponent<Rigidbody2D>();
        miSprite= GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        direccion = (jugador.position - transform.position).normalized;
        miRigidbody2D.MovePosition(miRigidbody2D.position + direccion * (velocidad * Time.fixedDeltaTime));
        
        

    }
    
    private void Update()
        {
        
        miSprite.flipX = direccion.x < 0;

         }
    
    }