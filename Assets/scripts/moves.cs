using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{

    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gamemoves();
    }

    void Gamemoves()
    {
        transform.Translate(Vector3.left * movespeed * Time.deltaTime);
    }
}
