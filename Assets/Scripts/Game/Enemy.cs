using System;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{

    public UnityEvent takeBulletEvent;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Bullet>()) 
            takeBulletEvent?.Invoke();
    }
}
