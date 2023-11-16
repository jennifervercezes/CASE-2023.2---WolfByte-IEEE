using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script do tiro, ainda tem que ser modificado
public class BulletScript : MonoBehaviour
{
    Transform target;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    public void SetTarget(Transform _taraget)
    {
        target = _taraget;
    }

    
    void FixedUpdate()
    {
        if (!target) return;
        
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);    
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
