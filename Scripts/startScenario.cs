using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScenario : MonoBehaviour
{
    private GameObject spawner;
    private GameObject m_text;
    private System.DateTime startTime;
    private System.DateTime currentTime;

    // timing variables
    private bool chronoOn = false;
    private int heure;
    private int minutes;
    private int secondes;
    private string chronoAff;

    EventParam eventParam;

    public void OnHandHoverBegin()
    {
        if (chronoOn == false)
        {
            spawner.SetActive(true);
            startTime = System.DateTime.UtcNow;
            chronoOn = true;
        }
    }

        // Start is called before the first frame update
    void Start()
    {
        // load prefab
        spawner = Resources.Load("Spawner") as GameObject;
        EventManager.StartListening("End", StopChrono);
    }

    // Update is called once per frame
    void Update()
    {
        if (chronoOn == true)
        {
            currentTime = (System.DateTime.UtcNow);

            heure = currentTime.Hour - startTime.Hour;
            minutes = currentTime.Minute - startTime.Minute;
            secondes = currentTime.Second - startTime.Second;

            if (secondes < 0)
            {
                secondes += 60;
                minutes -= 1;
            }
            if (minutes < 0)
            {
                minutes += 60;
                heure -= 1;
            }
            chronoAff = "Your time is: " + heure + ":" + minutes + ":" + secondes;
            eventParam = new EventParam(chronoAff);
            //EventManager.TriggerEvent("Chrono", eventParam);
            //
            //m_text.GetComponent<UnityEngine.UI.Text>().text = chronoAff;
        }
        EventManager.TriggerEvent("Chrono", eventParam);
    }

    void StopChrono(EventParam param)
    {
        chronoOn = false;
        //EventManager.TriggerEvent("Chrono", eventParam);
    }
}
