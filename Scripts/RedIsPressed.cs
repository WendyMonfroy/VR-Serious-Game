using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedIsPressed : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;

    Collider m_buttonCol;

    public void OnHoverRed()
    {
        m_Animator.SetTrigger("boutonRouge");
    }

    // Start is called before the first frame update
    void Start()
    {
        m_buttonCol = gameObject.GetComponent<Collider>();
        m_buttonCol.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
