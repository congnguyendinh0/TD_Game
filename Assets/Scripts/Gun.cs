using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private Transform _obj;
    
    public float fireRange = 15f;
    public float fireRate = 1f;
    private float _timer;
    
  
    public Transform partToRotate;
    public string enemyTag = "Enemy";
    public float turnSpeed =10f;

    
    // prefabs
    public GameObject bullet;
   // firepoint of gun
    public Transform firePoint;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("findNewEnemy",0f,0.2f);
    }

    void findNewEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        
        // find shortest distance 
        float shortestDistance = Mathf.Infinity;
        // at the beginning there is no near enemy
        GameObject closedE = null;
        
        foreach (GameObject e in enemies)
        {
            var distanceToEnemy = Vector3.Distance(transform.position, e.transform.position);
            if (!(distanceToEnemy < shortestDistance)) continue;
            shortestDistance = distanceToEnemy;
            closedE = e;
        }

        if (closedE != null && shortestDistance <= fireRange)
        {
            _obj = closedE.transform;
        }
        else
        {
            _obj = null;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (_obj == null)
            return;
// Rotation

        // direction vector
        // look at Object
        Vector3 _vectorDirection = _obj.position - transform.position;
        Quaternion _look_Rotation = Quaternion.LookRotation(_vectorDirection);
        // rotation 
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation,_look_Rotation,Time.deltaTime*turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f,rotation.y,0f);
        
        if (_timer <= 0f)
        {
            Fire();
            _timer = 1f / fireRate;
        }

        _timer -= Time.deltaTime;
    }

    void Fire()
    {
       Bullets bullets = ((GameObject)Instantiate(bullet, firePoint.position, firePoint.rotation)).GetComponent<Bullets>();
        
        
        if (bullets != null)
        {
          bullets.FollowTarget(_obj);
        }
        
    }


//Followed brackeys tutorial as allowed : https://www.youtube.com/watch?v=beuoNuK2tbk&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=1&ab_channel=Brackeys
}
