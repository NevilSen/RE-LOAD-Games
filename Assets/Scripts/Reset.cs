using UnityEngine;
using System.Collections;
using System.Timers;
using System;

public class Reset : MonoBehaviour
{
    Timer _timer = new Timer();

    static bool xxx = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            xxx = false;
        }
            
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           
            _timer.Interval = 5000;
            _timer.Elapsed += new ElapsedEventHandler(this.Checker);
            _timer.Start();
            
        }
    }

    public void Checker(object source, ElapsedEventArgs e)
    { 
        if(xxx == true)
        {
            Application.LoadLevel(Application.loadedLevel);
            _timer.Enabled = false;
            
        }
    }
}