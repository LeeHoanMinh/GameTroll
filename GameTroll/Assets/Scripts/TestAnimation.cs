using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ani.SetBool("Idle", true);
            ani.SetBool("Run", false);
            ani.SetBool("Jump", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ani.SetBool("Idle", false);
            ani.SetBool("Run", true);
            ani.SetBool("Jump", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ani.SetBool("Idle", false);
            ani.SetBool("Run", false);
            ani.SetBool("Jump", true);
        }
    }
}
