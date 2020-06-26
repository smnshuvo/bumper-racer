using UnityEngine;

public class player_controller : MonoBehaviour{

    public Rigidbody rb;
    public static float forwardForce = 400f;
    public static float sideForce = 120f;
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
    
    }
}
