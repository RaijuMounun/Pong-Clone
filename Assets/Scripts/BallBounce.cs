using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    BallMovement ballMovement;
    [SerializeField] ScoreManager scoreManager;

    private void Awake() => ballMovement = GetComponent<BallMovement>();

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if (collision.gameObject.name == "Player1") positionX = 1;
        else positionX = -1;

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionDetect(collision);
    }

    void CollisionDetect(Collision2D _collision)
    {
        if (_collision.gameObject.name.Contains("Player"))
        {
            Bounce(_collision);
            return;
        }
        if (_collision.gameObject.name.Contains("Border")) return;

        //If ball hits the left or right border
        scoreManager.PlayerScore(_collision.gameObject.name.Contains("Left") ? 1 : 0);
    }

}
