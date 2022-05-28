using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    // prefab
    public Transform enemyPrefab;
    public Transform spawnPoint;
    //
    public float waitingTime = 5f;
    private float _timer = 2f;
   
    private int _enemyIndex ;


    void Update()
    {
        // only spawn enemies if live > 0 
       
            if (_timer <= 0f)
            {
                // couritine
                if (HealthCounter.Health > 0)
                {
                    StartCoroutine(SpawnEnemies());
                }
              
                _timer = waitingTime;
            }

            _timer -= Time.deltaTime;
        


    }

   
    // spawning a wave of enemies
    
    IEnumerator SpawnEnemies()
 
    {
        _enemyIndex++;
        for (int i = 0; i< _enemyIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    
    }
   
    //  create enemy
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);
    }
   
}
//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys