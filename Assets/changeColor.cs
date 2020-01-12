using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))  rend.material.SetColor("_Color", Color.red);
        if(Input.GetKeyUp(KeyCode.Alpha2)) rend.material.SetColor("_Color", Color.green);
        if (Input.GetKeyUp(KeyCode.Alpha3)) rend.material.SetColor("_Color", Color.blue);
    }
}
