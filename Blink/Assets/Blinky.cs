using UnityEngine;
//using UnityEngine.UI;

//[RequireComponent(typeof(Text))]
public class Blinky : MonoBehaviour {
    [SerializeField] float blinkTime = 1f;

    [SerializeField]MonoBehaviour comp;
//    Text text;



//    void Awake()
//    {
//        text = GetComponent<Text>();
//    }



    void Start ()
    {
        InvokeRepeating("Blink", blinkTime, blinkTime);
	}



    void Blink()
    {
        comp.enabled = !comp.enabled;
//        text.enabled = !text.enabled;
    }
}
