using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tireProperties : MonoBehaviour
{

    private int defective;
    private int readable;

    public bool IsDefective() { return (defective == 1) ? true : false; }
    public bool IsReadable() { return (readable == 1) ? true : false; }

    // Start is called before the first frame update
    void Start()
    {
        defective = Random.Range(0, 2);
        readable = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
