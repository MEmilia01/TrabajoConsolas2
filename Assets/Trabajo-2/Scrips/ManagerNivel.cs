using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ManagerNivel : MonoBehaviour
{
    // Se necesita un sitio, para holdear los objetos
    [Header("Objetos necesarios")]
    public Transform puntospawn;
    public List<GameObject> objetosquemables = new List<GameObject>();


    public void ReactivarObjetos ()
    {

    }
}
