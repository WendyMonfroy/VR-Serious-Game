using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TireDetection : MonoBehaviour
{


    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        EventParam eventParam;

        
        if (collision.gameObject.name.Contains("Tire"))
        {
            
            
            // comment acceder a la fonction isdefective du pneu
            if (collision.gameObject.GetComponent<tireProperties>().IsDefective())
            {
                // SEND EVENT
                eventParam = new EventParam("error");
                

            }
            else if (!collision.gameObject.GetComponent<tireProperties>().IsDefective())
            {
                // SEND EVENT
                eventParam = new EventParam("conform");
            }
            else
            {
                eventParam = new EventParam("waiting");
            }

            EventManager.TriggerEvent("Material", eventParam);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        EventParam eventParam = new EventParam("waiting");
        EventManager.TriggerEvent("Material", eventParam);
    }
}
