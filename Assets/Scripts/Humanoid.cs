using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Humanoid : MonoBehaviour
{
    protected string speciesName;
    protected int force;
    protected float jumpForce;

    protected int Force
    {
        get
        {
            return force;
        }
        set
        {
            if(value < 0)
            {
                Debug.LogError("You can't set a negative force.");
            }
            else
            {
                force = value;
            }
        }
    }

    protected float JumpForce
    {
        get
        {
            return jumpForce;
        }
        set
        {
            if(value < 0)
            {
                Debug.LogError("You can't set a negative jump force.");
            }
            else
            {
                jumpForce = value;
            }
        }
    }

    protected abstract void Init();

    protected void Presentation()
    {
        Debug.Log($"Hello, I'm a {speciesName}, I {CanOrNot()} use heavy weapons, {ShowOff()}");
    }

    private string CanOrNot()
    {
        if(force < 7)
        {
            return "can't";
        }
        else
        {
            return "can";
        }
    }

    private string ShowOff()
    {
        string showOff;
        if(force >= 7)
        {
            showOff = "and";
        }
        else
        {
            showOff = "but";
        }
        if(jumpForce >= 7)
        {
            showOff += " I jump very high.";
        }
        else
        {
            showOff += "… no, forget it.";
        }
        return showOff;
    }

    protected void OnMouseDown()
    {
        Presentation();
    }
}
