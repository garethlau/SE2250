﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    public GameObject ThirdCam;
    public GameObject FirstCam;
    public static int CamMode;
    // Update is called once per frame
    void Start(){
        if(CamMode == 0 ){
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        if(CamMode == 1){
            ThirdCam.SetActive(false);
            FirstCam.SetActive(true);
        }
    }
    void Update()
    {
        if(Input.GetButtonDown("Camera")){
            if(CamMode == 1){
                CamMode = 0;
            }
            else{
                CamMode += 1;
            }
            StartCoroutine (CamChange());
        }
    }
    IEnumerator CamChange(){
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0 ){
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        if(CamMode == 1){
            ThirdCam.SetActive(false);
            FirstCam.SetActive(true);
        }
    }
}
