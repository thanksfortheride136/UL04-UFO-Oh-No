using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAliens : MonoBehaviour
{
    public int speed;
    private float moveTime = 5.0f;
    public float moveTimer;

    // Update is called once per frame
    void Update()
{
    transform.Translate(Time.deltaTime * speed, 0.0f, 0.0f);
    moveTimer += Time.deltaTime; // Corrected: Removed parentheses from deltaTime

    // Corrected: Use greater than or equal comparison instead of equality
    if (moveTimer >= moveTime)
    {
        moveTimer = 0.0f; // Reset timer
        speed *= -1; // Reverse direction
    }
}

}
