using UnityEngine;

public class addPointsToText : MonoBehaviour {
    
    //I have made these public because several scripts access these
    public static int currentPoints = 0;
    public static int scoreMultiplier = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //this, like everything i do, has bad naming. so this script is also responsible for destroying the sphere's
        if (other.CompareTag("node"))
        {
            //if it is a node (literally nothing else it could be) get a point!
            currentPoints += scoreMultiplier * scoreMultiplier;
            //because you got a point, get BONUS points....but no more than 10.
            if (scoreMultiplier < 10)
            {
                scoreMultiplier++;
            }
            if (scoreMultiplier > 10)
                scoreMultiplier = 10;
            if (scoreMultiplier < 1)
                scoreMultiplier = 1;
        }
    }
}
