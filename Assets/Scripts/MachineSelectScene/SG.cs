using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class MachineSelectData {
    public int id;
}
public class SG : MonoBehaviour
{
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.interactable = false;
    }
    public void OnClick()
    {
        var machine = GameObject.Find("MachineSelectManager");
        var id = machine.GetComponent<MachineSelectManager>().id;
        var str = "Slelected machine ID is " + id.ToString();
        Debug.Log(str);
        MachineSelectData data = new MachineSelectData(){ id = id };
        StartCoroutine(SceneTransitioner.Transition("CityTrial", data));
    }
}