using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{

    void OnCollisionEnter2D()
    {
            Destroy(gameObject); // Destroying Projectile upon collision with walls.
    }
}
