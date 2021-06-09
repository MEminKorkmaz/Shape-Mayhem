using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed;

    Vector2 movement;

    Vector2 topEdge;
    Vector2 rightEdge;
    Vector2 bottomEdge;
    Vector2 leftEdge;

    void Start(){
        topEdge = new Vector2(0f , 11.5f);
        rightEdge = new Vector2(27f , 0f);
        bottomEdge = new Vector2(0f , -11.5f);
        leftEdge = new Vector2(-27f , 0f);
        
    }

    void Update()
    {
        if(transform.position.x > rightEdge.x){
            transform.position = new Vector3(rightEdge.x , transform.position.y , transform.position.z);
        }
        if(transform.position.x < leftEdge.x){
            transform.position = new Vector3(leftEdge.x , transform.position.y , transform.position.z);
        }
        if(transform.position.y > topEdge.y){
            transform.position = new Vector3(transform.position.x , topEdge.y , transform.position.z);
        }
        if(transform.position.y < bottomEdge.y){
            transform.position = new Vector3(transform.position.x , bottomEdge.y , transform.position.z);
        }

        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate(){
        Move();
        lookRotation();
    }

    void Move(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void lookRotation(){
    Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    Vector3 lookAt = mouseScreenPosition;

    float AngleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);

    float AngleDeg = (180 / Mathf.PI) * AngleRad;

    var offset = 0f;

    this.transform.rotation = Quaternion.Euler(0, 0, (AngleDeg + offset));
    }
}
