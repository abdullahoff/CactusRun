
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement moveing;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            moveing.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

