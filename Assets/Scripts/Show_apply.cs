using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_apply : MonoBehaviour {

    public GameObject button_apply;
    public GameObject BuildButton;
    public GameObject CancelButton;
    public GameObject Circle_Quality;
    // Use this for initialization

    public void show_btn_apply()
    {
        button_apply.SetActive(true);
    }
    public void hide_btn_apply()
    {
        button_apply.SetActive(false);
        BuildButton.SetActive(false);
        CancelButton.SetActive(true);
        Circle_Quality.SetActive(false);
    }
    public void press_cancel_btn()
    {
        button_apply.SetActive(false);
        BuildButton.SetActive(true);
        CancelButton.SetActive(false);
        Circle_Quality.SetActive(true);
    }
}
