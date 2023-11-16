using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script que spawna as torres
public class TurretSpawner : MonoBehaviour
{
    public static TurretSpawner main;
    public  GameObject[] turretType;
    public int turretIndex = -1;

    void Awake()
    {
        main = this; 
    }

    public GameObject GetTurret()
    {
        return turretType[turretIndex];
    }


}
