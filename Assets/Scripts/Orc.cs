using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Humanoid
{
    void Start()
    {
        Init("n Orc", 10, 6);// INHERITANCE and Init() is an // ABSTRACTION
    }

    protected override void Insecurity()// POLYMORPHISME
    {
        speech += "\nI think my war paintings are not variegated enough.";
    }
}
