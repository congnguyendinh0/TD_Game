using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOptions : MonoBehaviour
{


//Singleton  method

    public static BuildOptions Ins;

    void Awake()
    {
        if (Ins != null)
        {
            return;
        }
        Ins = this;
    }
    public GameObject gunPrefab;

    
    // new name
    public GameObject rocketlauncherPrefab;

    private GameObject _character;

    public GameObject SelectCharacter()
    {
        return _character;
    }
    public void SetCharacter(GameObject character)
    {
     
        
        _character = character;
    }
}
//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
