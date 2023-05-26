using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float startSpeed, extraSpeed, maxExtraSpeed;
    [SerializeField] int hitCounter = 0;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    IEnumerator Launch()
    {
        hitCounter = 0;
        yield return new WaitForSeconds(2);
        MoveBall(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed + hitCounter * extraSpeed;
        rb.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter * extraSpeed < maxExtraSpeed) hitCounter++;
    }

    public void RestartBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        StartCoroutine(Launch());
    }
}
