using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TreeFactory : factory
{
    public GameObject treePrefab;

    public override GameObject CreateObject(Vector3 position)
    {
        // Instancia el prefab de �rbol en la posici�n dada
        return Instantiate(treePrefab, position, Quaternion.identity);
    }
}

