using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public float spawnRate = 1f;
        public float spawnRadius = 1f;
        public float force = 300f;

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, spawnRadius);   
        }

        void Start()
        {
            // InvokeRepeating(functionName, time, repeatRate);
            // functionName = name of the function that you want to call
            // time         = delay for when the function called for the first time
            // repeatRate   = how often the function get called
            InvokeRepeating("Spawn",0, spawnRate);
        }
        void Spawn()
        {
            // Intantiate a new GameObject
            GameObject enemy = Instantiate(enemyPrefab);
            // Position it to a random place within the spawn radius
            enemy.transform.position = Random.insideUnitCircle * spawnRadius;
            // Apply force to a rigidbody randomly
            Rigidbody2D rigid2d = enemy.GetComponent<Rigidbody2D>();
            rigid2d.AddForce(Random.insideUnitCircle * force);
        }
    }

}
