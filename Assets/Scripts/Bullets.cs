using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour{
  
  [Header("Changeable")]
  private Transform _t;
  public float rad;
  public float bSpeed = 80f;
  
  //follow
  public void FollowTarget(Transform t)
  {
    _t = t;
  }

   void Update()
  {
    if (_t == null)
    {
      Destroy(gameObject);
      return;
    }
    float distanceNow = bSpeed * Time.deltaTime;
    Vector3 dir = _t.position - transform.position;

    // direction vector ->  // length of vector
    if (dir.magnitude <= distanceNow)
    {
      TouchT();
      return;
    } 
    transform.Translate((_t.position - transform.position).normalized *distanceNow,Space.World);
    // look at target
    transform.LookAt(_t); 
  }

   void TouchT()
   {
     if (rad > 0f)
     {
       Explode();
     }
     else
     {
       RemoveE(_t);
     } Destroy(gameObject);
   }

   void RemoveE(Transform enemy)
   {
     Destroy(enemy.gameObject);
   }

   
   // explode when hit enemy
   // ReSharper disable Unity.PerformanceAnalysis
   void Explode()
   {
     foreach (Collider c in Physics.OverlapSphere(transform.position, rad))
     {
       if (c.CompareTag("Enemy"))
       {
         Destroy(c.gameObject);
       }
     }
   }
    

//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
}
