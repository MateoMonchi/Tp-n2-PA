using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BushFactory : factory
{
    public GameObject bushPrefab;

    public override GameObject CreateObject(Vector3 position)
    {
        // Instancia el prefab de arbusto en la posición dada
        return Instantiate(bushPrefab, position, Quaternion.identity);
    }
}

