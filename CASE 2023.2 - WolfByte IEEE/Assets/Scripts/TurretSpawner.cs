using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script que spawna as torres
public class TurretSpawner : MonoBehaviour
{
    public static TurretSpawner main;
    public  GameObject[] turretType;
    public int turretIndex = 4;
    public int custoTorre;

    void Awake()
    {
        main = this; 
    }

    public GameObject GetTurret()
    {
        custoTorre = turretType[turretIndex].GetComponent<Caldeirao>().custo;
        if (GameManager.Instance.economia.Use(custoTorre))
        {
            return turretType[turretIndex];
            
        }else
            return turretType[4];
           
        

    }


}
