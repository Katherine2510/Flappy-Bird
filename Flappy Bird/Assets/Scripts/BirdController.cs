using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    GameObject obj;
    public GameObject gameController;
    public float flyPower;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        
        flyPower = 200;
    }

    // Update is called once per frame
    //Muốn xử lý va chạm thì ít nhất 1 đối tượng phải có rigid body
    //cả hai đối ttuowngj phải có collider
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            audioSource.Play();
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, flyPower));
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        audioSource.clip = gameOverClip;
        audioSource.Play();
        if (other.gameObject.tag.Equals("Wall"))
            gameController.GetComponent<GameController>().EndGame();
    }
   
   


}
