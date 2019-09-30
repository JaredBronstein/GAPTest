using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTranslate : MonoBehaviour
{
    [SerializeField]
    private Vector3 Movement = new Vector3(1,1,1);
    void Update()
    {
        this.transform.Translate(Movement);
    }
}
