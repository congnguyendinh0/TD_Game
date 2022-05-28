using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;using UnityEngine.UI;

public class Health : MonoBehaviour


{

    public Text healthText;

 
    // Update is called once per frame
 
    void Update()
    {

        HealthUpdate();
            
    }

    void HealthUpdate()
    {
        const string nlives = "x";
        var amount = HealthCounter.Health;
        var health = new StringBuilder(nlives.Length * amount).Insert(0, nlives, amount).ToString();

        if (amount > 0)
        {
            healthText.text = "Health: " + health;}
        else
        {
            healthText.text = "";
        }
    }
    //  string repeat mehtod inspired by : https://www.codingame.com/playgrounds/5113/implementing-repeat-method-for-strings-in-c
    }

//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys