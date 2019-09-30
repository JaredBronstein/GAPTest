using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotate : MonoBehaviour
{
    [SerializeField]
    private int speed = 20;

    void Update()
    {
        this.transform.Rotate(0,0,speed*Time.deltaTime);
    }
}
