using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elfe : Humanoid
{
    void Start()
    {
        Init("n Elfe", 6, 10);// INHERITANCE and Init() is an // ABSTRACTION
    }

    protected override void Insecurity()// POLYMORPHISME
    {
        speech += "\nDo you think my ears are pointed enough?";
    }
}
