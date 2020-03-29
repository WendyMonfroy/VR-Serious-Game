using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenIsPressed : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;

    Collider m_buttonCol;

    private System.DateTime startTime;
    private System.DateTime currentTime;
    private GameObject m_text;
    private GameObject spawner;

    // timing variables
    private bool chronoOn = false;
    private int heure;
    private int minutes;
    private int secondes;
    private string chronoAff;

    public void OnHoverGreen()
    {
        m_Animator.SetTrigger("boutonVert");
        spawner.SetActive(true);
        startTime = System.DateTime.UtcNow;
        chronoOn = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
        m_buttonCol = gameObject.GetComponent<Collider>();
        m_buttonCol.isTrigger = false;
        //startTime = System.DateTime.UtcNow;
        m_text = GameObject.Find("TextScore");

        // load prefab
        spawner = Resources.Load("Spawner") as GameObject;
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
            // m_text.GetComponent<Text>().setText(chronoAff);
        }
        
        
    }
}
