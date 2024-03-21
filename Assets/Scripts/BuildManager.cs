using System;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one build Manager in scene");
            return;
        }
        instance = this;
        
    }

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
    // Start is called before the first frame update
    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
