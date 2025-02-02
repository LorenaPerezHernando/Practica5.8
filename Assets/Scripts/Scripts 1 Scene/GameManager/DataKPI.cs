using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Recolectable;


public class DataKPI : MonoBehaviour
{

    [SerializeField] int kpiRecolect1;
    [SerializeField] int kpiRecolect2;
    [SerializeField] int kpiRecolect3;
    public int recolectados;
    FirstStart_CreateRecolectables s_CreateRecolectable;
    //Methods
    private void Awake()
    {
        s_CreateRecolectable = FindFirstObjectByType<FirstStart_CreateRecolectables>();
    }
    void Start()
    {
        kpiRecolect1 = 0;
        kpiRecolect2 = 0;
        kpiRecolect3 = 0;
        recolectados = 0; 
    }
    public void IncrementarKPI(Recolectable.KPIType tipoKPI)
    {
        switch (tipoKPI)
        {
            case KPIType.recolectable1KPI:
                kpiRecolect1++;
                recolectados++;
                Debug.Log("Recolectable 1: " + kpiRecolect1);
                break;
            case KPIType.recolectable2KPI:
                kpiRecolect2++; recolectados++;
                Debug.Log("Recolectable 2: " + kpiRecolect2);
                break;
            case KPIType.recolectable3KPI:
                kpiRecolect3++; recolectados++;
                Debug.Log("Recolectable 3: " + kpiRecolect3);
                break;
        }
       
        print ("Obj Recolectados: " + recolectados);
    }


    public void SendData(Recolectable.KPIType tipoKPI)
    {

    }
}
