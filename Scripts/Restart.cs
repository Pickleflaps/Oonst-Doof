using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    //this is my button, it can be any button
    public Button myButton;

    void Start()
    {
        //get that button and spy on it
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        //AHH you clicked it, DO A THING!
        addPointsToText.currentPoints = 0;
        SceneManager.LoadScene("Level1");
    }
}
