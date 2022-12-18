using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private PlayerActions inputs;
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 moveDir;

    void Awake(){
        inputs = new PlayerActions();
    }

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() {
        inputs.Enable();
    }

    private void OnDisable() {
        inputs.Disable();
    }

    void Update()
    {
        
    }
    
    void FixedUpdate() {
        moveDir = inputs.PlayerController.Movement.ReadValue<Vector2>();
        Vector3 pos = new Vector3(moveDir.x * speed, moveDir.y * speed, 0f);
        playerRb.MovePosition(transform.position + pos * Time.deltaTime);
    }
}
