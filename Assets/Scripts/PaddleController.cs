using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rig;

    [SerializeField] 
    private KeyCode upKey, downKey;

    private void Start() {
        rig = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    // get input
    private Vector2 GetInput() {
           
        if (Input.GetKey(upKey)) {
            return Vector2.up * speed;
        }     
        if (Input.GetKey(downKey)) {
            return Vector2.down * speed;
        }
       
        return Vector2.zero;
    }

    // Move object
    private void MoveObject(Vector2 movement) {
        rig.velocity = movement;
    }
}
