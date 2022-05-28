using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float movement = 10f;
    private Transform _target;
    
    //index of wavepoint
    private int _index = 0;
    void Start()
    {
        _target = WayPoints.Pointers[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        // move
        Vector3 direction = _target.position - transform.position;
        // needs to be normalized
        
        transform.Translate(direction.normalized * (movement * Time.deltaTime),Space.World);
        if (Vector3.Distance(transform.position, _target.position) <= 0.2f)
            // get next
        {
            MoveTo();
        }
        
    }
    
    // move to next way point
    void MoveTo()
    {
        if (_index >= WayPoints.Pointers.Length - 1)
        {
            PathEnded();
            Destroy(gameObject);
            return;
        }
        _index++;
        _target = WayPoints.Pointers[_index];
    }
    void PathEnded()
    {
        // had to add this to avoid -1 lives
        if(HealthCounter.Health>0)
        {
            HealthCounter.Health--;
            //destroys enemy at end
            Destroy(gameObject);  
        }
        
    }
}
//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys