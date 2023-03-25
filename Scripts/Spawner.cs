using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public List<GameObject> towersPrefabs;
    public List<Image> towersUI;
    public Transform spawnTowerRoot;

    int spawnID = -1;

    public Tilemap spawnTilemap;

    private void Update()
    {
        
        if (spawnID != -1)
        {
            DetectSpawnPoint();
        }
        else
        {
            DeselectTower();
        }
    }

    bool CanSpawn()
    {
        if (spawnID == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void DetectSpawnPoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var cellPositionDefault = spawnTilemap.WorldToCell(mousePosition);
            var cellPositionCentered = spawnTilemap.GetCellCenterWorld(cellPositionDefault);
            if (spawnTilemap.GetColliderType(cellPositionDefault) == Tile.ColliderType.Sprite)
            {
                int towercost = TowerCost();
                if (GameManager.instance.currency.EnoughCurrency(TowerCost()))
                {
                    GameManager.instance.currency.Use(towercost);
                    SpawnTower(cellPositionCentered);
                    spawnTilemap.SetColliderType(cellPositionDefault, Tile.ColliderType.None);
                }
                
            }
            

        }
    }

    int TowerCost()
    {
        switch (spawnID)
        {
            case 1: return towersPrefabs[1].GetComponent<IncomeTower>().cost;
            default:return -1;
        }
    }

    void SpawnTower(Vector3 position)
    {
        GameObject tower = Instantiate(towersPrefabs[spawnID],spawnTowerRoot);
        tower.transform.position= position;

        
        DeselectTower();
    }

    public void SelectTower(int id)
    {
        DeselectTower();
        spawnID = id;
        towersUI[spawnID].color = Color.white;

    }

    public void DeselectTower()
    {
        spawnID = -1;
        foreach(var t in towersUI)
        {
            t.color = new Color(0,4f,0.4f,0.4f);
        }
    }
}
