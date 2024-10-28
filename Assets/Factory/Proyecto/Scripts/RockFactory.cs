using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RockFactory : factory
{
    public GameObject rockPrefab;

    public override GameObject CreateObject(Vector3 position)
    {
        // Instancia el prefab de roca en la posición dada
        return Instantiate(rockPrefab, position, Quaternion.identity);
    }
}

