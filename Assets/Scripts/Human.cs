using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Humanoid
{
    void Start()
    {
        Init();
    }
    protected override void Init()
    {
        speciesName = "Human";
        Force = 6;
        JumpForce = 6;
    }
}