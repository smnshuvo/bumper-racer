using UnityEngine;


public class player_collision : MonoBehaviour
{
    // this script is used to get if the player has collided with the enemy cars
    
    // keep traces of player movement
    public player_controller movement;
    
    
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "enemy"){
                // the game should be over
                Debug.Log("Game Over");
                // stop moving the car right there
                movement.enabled = false;
        }
    }
}
