﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor5 : ParentDoor{
	
    public override void Doors()
    {
        if (Input.GetKeyDown("g")){  //キーは小文字のみ

            GameObject Parent = transform.root.gameObject;
            Destroy(Parent);
            MagicScript.Instance.Camera.GetComponent<SceneManager>().CountDoor += 1;
            MagicScript.Instance.Camera.GetComponent<SceneManager>().Opend = true;

            Debug.Log("Open");
        }
    }
}
