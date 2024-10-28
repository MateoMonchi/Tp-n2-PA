using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerUI : MonoBehaviour
{
    public BushFactory bushFactory;
    public RockFactory rockFactory;
    public TreeFactory treeFactory;

    // M�todos que ser�n llamados por los botones de UI
    public void SpawnBush()
    {
        Vector3 spawnPosition = GetRandomPosition();
        bushFactory.CreateObject(spawnPosition);
    }

    public void SpawnRock()
    {
        Vector3 spawnPosition = GetRandomPosition();
        rockFactory.CreateObject(spawnPosition);
    }

    public void SpawnTree()
    {
        Vector3 spawnPosition = GetRandomPosition();
        treeFactory.CreateObject(spawnPosition);
    }

    // M�todo para generar una posici�n aleatoria
    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }
}


