using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//script que tava na capacitação inalterado
//tem que ser feitas alterações pq nesse script as torres atiram em 360 graus em vez de só pra frente
//provavelmente vai substituir o script "player"
public class TurretController : MonoBehaviour
{
    [SerializeField] float targetingRange = 5f; //range da turret
    [SerializeField] LayerMask enemyMask; //layer onde os inimigos estão
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firingPoint;
    float bps = 1f; //balas por segundo
    float tempoDeFogo; //tempo entre os tiros

    void OnDrawGizmosSelected()
    {
        Handles.color = Color.magenta;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }

    Transform target;
    void Update()
    {
        if(target == null)
        {
            FindTarget();
            return;
        }
        if (!CheckTargetIsinRange())
        {
            target = null;
        }
        else
        {
            tempoDeFogo += Time.deltaTime;
            if (tempoDeFogo >= (1f / bps))
            {
                Shoot();
                tempoDeFogo = 0f;
            }
        }


    }
    void FindTarget()
    {
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, targetingRange, (Vector2)transform.position, 0f, enemyMask);
        if(hits.Length > 0 )
        {
            target = hits[0].transform;
        }
    }
    void Shoot()
    {
        GameObject bulletObj = Instantiate(bullet, firingPoint.position, Quaternion.identity);
        BulletScript bulletScript = bulletObj.GetComponent<BulletScript>();
        bulletScript.SetTarget(target);
    }

    bool CheckTargetIsinRange()
    {
        return (Vector2.Distance(target.position, transform.position)<= targetingRange);
    }
}
