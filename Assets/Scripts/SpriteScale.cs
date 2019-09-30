using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScale : MonoBehaviour
{
    [SerializeField]
    private Vector3 scaleSize;
    void Update()
    {
        this.transform.localScale = scaleSize;
        scaleSize.x += 1;
        scaleSize.y += 1;
        scaleSize.z += 1;
    }
}
