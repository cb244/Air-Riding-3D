using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MachineSelect : MonoBehaviour
{
    public int id;
    public AudioClip SE_select;
    public AudioClip SE_hover;
    public void OnClick()
    {
        GameObject.Find("SE").GetComponent<AudioSource>().PlayOneShot(SE_select, 0.5f); // SE (select)
        var machine = GameObject.Find("MachineSelectManager");
        machine.GetComponent<MachineSelectManager>().id = id;
        var str = "Selected machine ID is " + machine.GetComponent<MachineSelectManager>().id;
        Debug.Log(str);
        ButtonManager.SetInteractive("Button_StartGame", true);
    }
    public void PointerEnter()
    {
        GameObject.Find("SE").GetComponent<AudioSource>().PlayOneShot(SE_hover, 0.2f); // SE (hover)
    }
}