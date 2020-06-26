using UnityEngine;
using UnityEngine.UI;
public class player_controller : MonoBehaviour{

    public Rigidbody rb;
    public static float forwardForce = 400f;
    public static float sideForce = 120f;
    public static float topForce = 550f;
    public Text scoreText;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void FixedUpdate() {
           // constantly add a force to the forward directory        
        //rb.AddForce(0,0,forwardForce * Time.deltaTime);
        // Though we don't need a force mode here
        // as we have changed our plan from making the car move to making the objects move
        if(Input.GetKey("d")){
            rb.AddForce(sideForce * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space")){
            // should be added a jump feature that will help the car to jump
            // below code leads to problem, you have to hold the space key strongly
            if(rb.position.y < 15)  // won't let you jump twice          
            rb.AddForce(0, topForce * Time.deltaTime,0, ForceMode.VelocityChange);
        }
        // controller updates the score
        updateScore();
    
    }

    void updateScore(){
        scoreText.text = (Time.frameCount/10).ToString("D8");
    }
}
