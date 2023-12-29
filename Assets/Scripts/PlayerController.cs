using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] bool isPlayer1;
    [SerializeField] float speed;
    Rigidbody2D rb;
    string verticalAxisName;

    private void Awake() => rb = GetComponent<Rigidbody2D>();

    private void Start()
    {
        if (isPlayer1) verticalAxisName = "Vertical";
        else verticalAxisName = "Vertical2";
    }

    private void Update()
    {
        rb.velocity = Vector2.up * Input.GetAxisRaw(verticalAxisName) * speed;
    }
}
