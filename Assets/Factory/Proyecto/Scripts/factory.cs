using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class factory : MonoBehaviour
{

    // Este m�todo abstracto debe ser implementado por cada subclase
    public abstract GameObject CreateObject(Vector3 position);
}


