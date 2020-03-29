using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchAff : MonoBehaviour
{

    // definir material a modifier
    private Material wait;
    private Material conform;
    private Material error;


    // Start is called before the first frame update
    void Start()
    {
        wait = Resources.Load("Materials/Waiting", typeof(Material)) as Material;
        conform = Resources.Load("Materials/Conform", typeof(Material)) as Material;
        error = Resources.Load("Materials/Error", typeof(Material)) as Material;

        EventManager.StartListening("Material",UpdateScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScreen(EventParam param)
    {
        // modifier material
        if(param.getParam()=="error")
        {
            transform.GetComponent<Renderer>().material = error;
        }
        else if (param.getParam() == "conform")
        {
            transform.GetComponent<Renderer>().material = conform;
        }
        else if (param.getParam() == "waiting")
        {
            transform.GetComponent<Renderer>().material = wait;
        }


    }
}
