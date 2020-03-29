using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benneKOscript : MonoBehaviour
{
    // Start is called before the first frame update
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
        Debug.Log("eho?");

        if (collision.gameObject.name.Contains("Tire"))
        {

            if (collision.gameObject.GetComponent<tireProperties>().IsDefective())
            {
                // SEND EVENT stop chrono
                eventParam = new EventParam("okstop");
                EventManager.TriggerEvent("End", eventParam);
            }



        }
    }
}
