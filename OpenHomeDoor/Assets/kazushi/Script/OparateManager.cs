﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OparateManager: MonoBehaviour
{
    //private Door Door;
    //public  Vector3 UnChenged;
    [SerializeField] private int HowManyDoors;
    public int CountDoor;
    private ParentDoor ParentDoor;
    public bool Opend;
    public bool GameClear;
   
    public LayerMask LayerMaskOfDoor;
    public GameObject Door1Prefab;
    public GameObject Door2Prefab;
    public GameObject Door3Prefab;
    public GameObject Door4Prefab;
    public GameObject Door5Prefab;
    public GameObject Door6Prefab;


    void Start()
    {
        //UnChenged = new Vector3(0, 0, 0);
        CountDoor = 0;
        ParentDoor = GetComponent<ParentDoor>();
        MagicScript.Instance.Camera = this.gameObject;
        Debug.Log(this.gameObject);
        Opend = true;
        GameClear = false;
    }

    void Update()
    {
        
        if(CountDoor == HowManyDoors){

            GameClear = true;

        }
        else if(Opend){
            SpownDoor();
        }
        OpenDoor();
    }


    public void OpenDoor()
    {

        Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;  //ヒットしたオブジェクトの情報を格納する。

        if (Physics.Raycast(MouseRay, out hit, Mathf.Infinity, LayerMaskOfDoor))  //outでオブジェクトの情報を得る。
        {
            Debug.DrawRay(MouseRay.origin, MouseRay.direction, Color.red,100.0f);
            hit.collider.GetComponent<ParentDoor>().Doors();

        }
    }

    public void SpownDoor(){

        int rand = (int)Random.Range(1, 6);
        switch (rand)
        {
            case 1:
                Instantiate(Door1Prefab);
                //UnChenged = Door1Prefab.transform.position;
                break;
            case 2:
                Instantiate(Door2Prefab);
                break;
            case 3:
                Instantiate(Door3Prefab);
                break;
            case 4:
                Instantiate(Door4Prefab);
                break;
            case 5:
                Instantiate(Door5Prefab);
                break;
            case 6:
                Instantiate(Door6Prefab);
                break;
        }
        Opend = false;
    }
}

    






