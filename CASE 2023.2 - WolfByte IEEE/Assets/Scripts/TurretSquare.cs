using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script dos quadrados onde as torres podem ser colocadas
public class TurretSquare : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Color hoverColor;

    GameObject turret;
    Color startColor;
    void Start()
    {
        startColor = sr.color;
    }
    void OnMouseEnter()//mudar pra deixar as torres piscando em vez de elas sumirem(elas somem por algum motivo que eu nao sei)
    {
        sr.color = hoverColor;
    }
    void OnMouseExit()
    {
        sr.color = startColor;
    }
    void OnMouseDown()
    {
        if (turret != null) return;
        GameObject turretBuild = TurretSpawner.main.GetTurret();
        turret = Instantiate(turretBuild, transform.position, Quaternion.identity);
    }
}
