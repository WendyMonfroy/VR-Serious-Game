using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consoleScript : MonoBehaviour
{
    GameObject child;
    GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        child = gameObject.transform.GetChild(0).gameObject;
        score = child.transform.GetChild(0).gameObject;
        EventManager.StartListening("Chrono", UpdateScore);
        EventManager.StartListening("End", DisplayKeyboard);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScore(EventParam param)
    {
        score.GetComponent<UnityEngine.UI.Text>().text = param.getParam();
    }
    void DisplayKeyboard(EventParam param)
    {
        child.SetActive(true);
    }
}
