using UnityEngine;
using UnityEngine.UI;

public class player_collision : MonoBehaviour
{
    public Text scoreBoard;
    // this script is used to get if the player has collided with the enemy cars
    
    // keep traces of player movement
    public player_controller movement;
    
    
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "enemy"){
                // the game should be over
                Debug.Log("Game Over");
                // stop moving the car right there
                movement.enabled = false;
                scoreBoard.text = "Game Over";
        }
    }
}
