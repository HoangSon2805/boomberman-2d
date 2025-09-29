using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Rigidbody2D rigibody { get;private set; }
    private void Awake() {
        rigibody = GetComponent<Rigidbody2D>();
    }
}
