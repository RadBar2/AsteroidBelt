using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20000;
    public float lifetime = 3;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    
    

}
