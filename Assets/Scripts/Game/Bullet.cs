using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
  
    public UnityEvent takeBulletEvent;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Enemy>()) 
            takeBulletEvent?.Invoke();
    }
    
    
}
