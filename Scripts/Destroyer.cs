using UnityEngine;

public class Destroyer : MonoBehaviour {
    // rule number 1) Personal space 
    //2) Personal space 
    //3) Stay out of my personal space 
    //4) Keep away from my personal space 
    //5) Get outta dat personal space 
    //6) Stay away from my personal space 
    //7) Keep away from dat personal space 
    //8) Personal space 
    //9) Personal space
    private void OnTriggerEnter(Collider other)
    {
        //im gonna kill you...
        Destroy(other.gameObject);
        //and take all your bonus points.
        addPointsToText.scoreMultiplier = 1;
    }
}
