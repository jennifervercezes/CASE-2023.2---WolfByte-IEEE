using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// scprit que seleciona as torres usando o menu(ainda falta elas custarem alguma coisa)
public class TurretSelect : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Color hoverColor;
    [SerializeField] int index;   

    GameObject turret;
    Color startColor;
    void Start()
    {
        startColor = sr.color;
    }
    void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    void OnMouseExit()
    {
        sr.color = startColor;
    }
    void OnMouseDown()
    {
        TurretSpawner.main.turretIndex = index;
    }

}
