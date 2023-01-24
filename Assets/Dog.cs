using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
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
        Debug.Log("Wow! Wow!");
    }
}
