using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField]float torqueAmount = 1f;
    [SerializeField]float normalBoostSpeed = 20f;
    [SerializeField]float boostSpeed = 30f;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            Rotate();
            Booster();
        }
    }
    
    public void DisableControl(){
        canMove = false;
    }
     void Booster()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed = boostSpeed;
        }else{
            surfaceEffector2D.speed = normalBoostSpeed;
        }
    }

     void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddTorque(-torqueAmount);
        }
    }
}
