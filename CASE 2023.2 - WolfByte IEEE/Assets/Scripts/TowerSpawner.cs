using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerSpawner : MonoBehaviour
{
    public List<GameObject> towers;
    public int spawnID = -1;
    public Tilemap spawnTilemap;
    void Update()
    {
        if(CanSpawn())
            DetectSpawnPoint();
    }
    bool CanSpawn()
    {
        if(spawnID == -1)
        {
            return false;
        }else
            return true; 
    }


    void DetectSpawnPoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var cellPosRaw = spawnTilemap.LocalToWorld(mousePos);
            Debug.Log(cellPosRaw);

        }
    }

    public void SelectTower(int id)
    {
    
    spawnID = id;
    }
    public void DeselectTower()
    {
        spawnID = -1;
    }

}
