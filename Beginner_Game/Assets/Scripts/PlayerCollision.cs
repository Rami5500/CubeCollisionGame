using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    


    void OnCollisionEnter (Collision info) {
        
        if (info.collider.tag == "obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManagement>().EndGame();

        }

    }

}
