using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour{

    
    // health manager 
   
    public static int Health;
   
    // to begin we have 5 health points
    public int health = 5;
    void Start()
    {
        Health = health;
    }


//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
}
