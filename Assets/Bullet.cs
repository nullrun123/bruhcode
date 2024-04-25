using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Bullet"&& collision.gameObject.tag != "canPickUp"&& collision.gameObject.tag != "water")
            Destroy(gameObject);
    }
}
