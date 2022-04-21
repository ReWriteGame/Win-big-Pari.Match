using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
    public UnityEvent takeBulletEvent;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Block>())
        {
            other.gameObject.GetComponent<Destroyable>().Destroy();
            takeBulletEvent?.Invoke();
        }
    }
}
