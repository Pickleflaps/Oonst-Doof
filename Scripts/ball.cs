using UnityEngine;

public class ball : MonoBehaviour {

    public float speed = 0.01f; //this number is arbitrary. it is set in the editor.
	
	void Update ()
    {
        //real complex stuff going on here...
        this.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
	}
}
