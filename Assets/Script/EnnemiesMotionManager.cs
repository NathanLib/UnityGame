using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesMotionManager : MonoBehaviour
{
    void Start() { }

    void Update() {
        transform.Translate(0, 0, -0.15f);
    }
}
