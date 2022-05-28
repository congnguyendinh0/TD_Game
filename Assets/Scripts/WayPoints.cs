using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[] Pointers;
    private void Awake()
    {
        Pointers = new Transform[transform.childCount];
        for (int pointer = 0; pointer < Pointers.Length; pointer++)
        {
            // get pointer 
            Pointers[pointer] = transform.GetChild(pointer);
        }
    }

    //Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
}
