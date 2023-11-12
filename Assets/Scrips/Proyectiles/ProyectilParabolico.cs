using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilParabolico : Proyectil
{
    [SerializeField]
    [Range(0f,180f)]
    private float launchAngle = 45f;
    protected override void Mover()
    {

        float launchAngleInRadians = launchAngle * Mathf.Deg2Rad;
        Vector2 launchVelocity =new Vector2(Mathf.Cos(launchAngleInRadians) * speed, Mathf.Sin(launchAngleInRadians) * speed);

        rb.velocity = launchVelocity;
    }

}
