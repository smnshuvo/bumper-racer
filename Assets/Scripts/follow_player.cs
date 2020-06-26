using UnityEngine;

public class follow_player : MonoBehaviour
{
    // to know player position
    public Transform player;
    // camera offset
    public Vector3 offset;
    /*
    We don't need to follow the player, we should be just fine making 
    the camera move left or right, but still it's good practise to do it.
    */
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate() {
        transform.position = player.position + offset;
    }
}
