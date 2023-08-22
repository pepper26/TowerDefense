using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;


     void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Đã mua tháp canh");
        buildManager.SetTurretToBuild(buildManager.standardTurretprefab);
    }
    
    public void PurchaseAnotherTurret()
    {
        Debug.Log("Đã mua 1 tháp canh khác");
        buildManager.SetTurretToBuild(buildManager.anotherTurretprefab);
    }
}
