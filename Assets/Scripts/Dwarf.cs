using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Humanoid
{
    void Start()
    {
        Init(" Dwarf", 10, 10);// INHERITANCE and Init() is an // ABSTRACTION
    }

    protected override void Insecurity()// POLYMORPHISME
    {
        speech += "\nWhat do you mean by \"I didn't see you\"?";
    }
}
