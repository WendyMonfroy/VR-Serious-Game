using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    /*
     waiting
     (user puts tire on bench)
        if readable 
            if defective
                print error
            else
                print conform
        else
            print no scan
            (user scans code)
            print error/conform
     (user removes tire)
     waiting
     (user puts in right box)
     congrats!
    */

    

    [SerializeField]
    private Animator m_Animator;

    // prefab object to spawn
    // create it in assets, delete it from the scene, call it here!
    private GameObject prefab;

    // Use this for initialization
    void Start()
    {
        
        prefab = Resources.Load("Prefabs/Tire") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // pas de mise a jour
    }

    void Awake()
    {
        // spawn new objects at regular intervals
    }

    public void OnButtonPushed()
    {
        // spawn 10
        StartCoroutine(LeWaiter());
    }

    void SpawnNext()
    {
        // random position
        float rdm = Random.Range(0f, 0.5f);
        GameObject newBox = Instantiate(prefab, transform);
        // position.x , position.y + transform.localScale.y / 2, position.z
        newBox.transform.localPosition = new Vector3(rdm, 0, 0);
    }

    IEnumerator LeWaiter()
    {
        // if the button is pushed

        //spawn 10 new objects
        for (int i = 0; i < 10; ++i)
        {
            Invoke("SpawnNext", 0.01f);
            //Wait
            yield return new WaitForSeconds(0.2f);
        }

    }


}
