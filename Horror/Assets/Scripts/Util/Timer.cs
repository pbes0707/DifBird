using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    // Timer Count (Mills)
    private float count = 0;
    private float incount = 0;
    private timer_func var;
    private bool isSet = false;
    private bool isWorked = false;

    public delegate void timer_func();

	// Use this for initialization
	private void Start () 
    {

	}
	
	// Update is called once per frame
	private void Update () 
    {
        if (isSet == false)
            return;

        if (isWorked == true)
            return;

        if (count <= 0)
        {
            isWorked = true;
            Debug.Log("Before var");
            var();
            Debug.Log("After var");
        }
        else if (count > 0)
        {
            count -= (Time.deltaTime * 1000);
        }
	}

    // param -> callback func
    // param_count -> Timer Count (Mills)
    // if has already settings Timer, quit function
    public void SetTimer(timer_func param, int param_count)
    {
        if (isSet)
            return;

        var = param;
        count = (float)param_count;
        isSet = true;

        Debug.Log("SetTimer Success");
    }
}