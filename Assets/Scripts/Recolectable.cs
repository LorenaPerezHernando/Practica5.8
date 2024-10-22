using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public enum KPIType
    {
        recolectable1KPI,
        recolectable2KPI,
        recolectable3KPI
    }
    //Properties
    public KPIType typeKPI;
    //Fields
    DataKPI s_dataKPI;


    //Methods
    private void Awake()
    {
        s_dataKPI = FindObjectOfType<DataKPI>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Recolectar();
            Destroy(gameObject, 0.5f);
        }
    }

    public void Recolectar()
    {
        s_dataKPI.IncrementarKPI(typeKPI);

        s_dataKPI.SendData(typeKPI);
    }
        
}
