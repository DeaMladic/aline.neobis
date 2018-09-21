using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public movem movement;
  

    void OnCollisionEnter(Collision collisionInfo)
    {
     
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}
