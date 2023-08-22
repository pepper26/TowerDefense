using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("b");
            return;
        }

        instance = this;
    }

    public GameObject standardTurretprefab;
    public GameObject anotherTurretprefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild() 
    { 
        return turretToBuild; 
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
