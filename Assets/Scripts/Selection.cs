using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Selection : MonoBehaviour
{
    
    private BuildOptions _buildOptions;

    private void Start()
    {
        _buildOptions =BuildOptions.Ins;
        ;
    }

    public void BuyGun()
    {
        _buildOptions.SetCharacter(_buildOptions.gunPrefab);
    }
    
    public void SelectRocketLauncher()
    {
        _buildOptions.SetCharacter(_buildOptions.rocketlauncherPrefab);
    }
}
//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys

