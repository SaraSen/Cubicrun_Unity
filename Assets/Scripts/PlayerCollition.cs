
using UnityEngine;

public class PlayerCollition : MonoBehaviour {

    public PlayerMovement movement;
   

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }

}
