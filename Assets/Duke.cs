using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duke : Pet
{
    // Start is called before the first frame update
    void Start()
    {
        Speak();
        Eat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Speak()
    {
        Debug.Log("Quak! Quak!");
    }
}
