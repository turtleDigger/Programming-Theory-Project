using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Humanoid : MonoBehaviour
{
    protected string speciesName, speech;
    protected int force, jumpForce; // ENCAPSULATION
    [SerializeField] protected GameObject speechTextPrefab;

    protected int Force // ENCAPSULATION
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

    protected int JumpForce // ENCAPSULATION
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

    protected void Init(string sN, int f, int jF) // ABSTRACTION
    {
        speciesName = sN;
        Force = f;
        JumpForce = jF;
        Speech();
    }

    private void Speech()
    {
        speech = $"Hello, I'm a{speciesName},\nI {CanOrNot()} use heavy weapons,\n{ShowOff()}";
        Insecurity();
    }

    protected abstract void Insecurity();// POLYMORPHISME

    private IEnumerator DisplaySpeech()
    {
        GameObject STP = Instantiate(speechTextPrefab, transform.position + Vector3.up, speechTextPrefab.transform.rotation);
        STP.GetComponent<TextMesh>().text = speech;
        yield return new WaitForSeconds(3);
        Destroy(STP);
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
            showOff += " I can jump very high.";
        }
        else
        {
            showOff += "… no, forget it.";
        }
        return showOff;
    }

    protected void OnMouseDown()
    {
        StartCoroutine(DisplaySpeech());
    }
}
