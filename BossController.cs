using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
    public static int a = 0;
    public float b = 0;
    public static int wonFlag = 0;
    public static float c = 0;
    public float timeCount = 0;
    public static  int timeCountInt =0;
    public static int distanceCountInt = 0;
    public static Rigidbody rb;
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource coinAudio;
    [SerializeField] Text distanceText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        b = rb.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount= Time.realtimeSinceStartup;
        timeCountInt = (int)timeCount;
        rb.MovePosition(rb.position + new Vector3(0, 0, 20) * Time.deltaTime);
      
        if (Input.GetKey("right"))
        {
            rb.MovePosition(new Vector3(4, rb.position.y, rb.position.z+0.5f));
        }
        if (Input.GetKey("left"))
        {
            rb.MovePosition(new Vector3(-4, rb.position.y, rb.position.z+0.5f));
        }
        c = (rb.position.z - b);
        distanceCountInt = (int)c;
        dist();
    }
    

    void dist()
    {
        distanceText.text = "Distance : " + distanceCountInt +"m"+ "            Time : "+ timeCountInt + "s";
    }

    void OnCollisionEnter(Collision col) {
       
        if (col.gameObject.name == "coin")
        {
            coinAudio.Play();
            a = a + 1;
            Destroy(col.gameObject);
            coinsText.text = "Orbs : " + a; 
        }
        if (col.gameObject.name == "Train")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (col.gameObject.name == "TrainEnd")
        {
            wonFlag = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (col.gameObject.name == "dec")
        {
            a--;
            Destroy(col.gameObject);
            coinsText.text = "Orbs : " + a;
        }
    }
}
