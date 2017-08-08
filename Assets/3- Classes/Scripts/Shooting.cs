using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{
    public class Shooting : MonoBehaviour
    {
        public GameObject projectilePrefab; // Stores the object we want to Instantiate  
        public float projectileSpeed = 20f; // Speed at which the projectile will flung
        public float shootRate = 0.1f; // Rate of fire
        private float shootTimer = 0f; // Timer to count shootRate
        private Rigidbody2D rigid; // Container for Rigidbody2D

        void Start()
        {
            rigid = GetComponent<Rigidbody2D>(); // Get component from GameObject this game attached to
        }

        void Update()
        {
            shootTimer += Time.deltaTime; // Increase timer

            if (Input.GetKey(KeyCode.Space) && shootTimer >= shootRate) // If spacebar is pressed AND shootTImer >= shootRate
            {
                Shoot(); // CALL Shoot()
                shootTimer = 0; // RESET shootTimer = 0
            }
        }
        void Shoot()
        {
            GameObject projectile = Instantiate(projectilePrefab); // Instantiate GameObject here
            projectile.transform.position = transform.position; // Projectile Position = Player Position
            Rigidbody2D rigid = projectile.GetComponent<Rigidbody2D>(); // Get Rigidbody2D Component
            rigid.AddForce(transform.right * projectileSpeed, ForceMode2D.Impulse); // OR rigid.velocity = transform.right * projectileSpeed; (Add force / velocity to the bullet)
        }
    }
}
