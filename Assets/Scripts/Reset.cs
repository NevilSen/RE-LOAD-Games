using UnityEngine;
using System.Collections;
using System.Timers;

public class Reset : MonoBehaviour
{
    static System.Timers.Timer _timer;

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
            _timer = new System.Timers.Timer();
            _timer.Interval = 5000;
            _timer.Elapsed += new ElapsedEventHandler(Checker);
            _timer.Enabled = true;
            xxx = true;
            
        }
    }

    public static void Checker(Object source, System.Timers.ElapsedEventArgs e)
    { 
        if(xxx == true)
        {
            Application.LoadLevel(Application.loadedLevel);
            _timer.Enabled = false;
            
        }
    }
}