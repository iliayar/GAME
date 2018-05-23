using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    public KeyCode ForwardKey = KeyCode.W;
    public KeyCode LeftKey = KeyCode.W;
    public KeyCode RightKey = KeyCode.W;
    public KeyCode BackwardKey = KeyCode.W;
    public float Angle = 0;
    public Rigidbody2D rb;
    public Animator anim;
    public float speed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    protected virtual void PerformMove()
    {
        

        Vector2 vRes;
        Vector2 v;



        vRes = new Vector2(0,0);

        if (Input.GetKey(KeyCode.Escape))
        {
            if(!SceneManager.GetSceneByName("Play_menu").isLoaded)
            {
                SceneManager.LoadScene("Play_menu", LoadSceneMode.Additive);
            }
        }

        if (Input.GetKey(ForwardKey))
        {
            v = new Vector3(0, speed);
            vRes += v;
        }
        if (Input.GetKey(BackwardKey))
        {
            v = new Vector3(0, -speed);
            vRes += v;
        }
        if (Input.GetKey(LeftKey))
        {
            v = new Vector3(-speed, 0);
            vRes += v;
        }
        if (Input.GetKey(RightKey))
        {
            v = new Vector3(speed, 0);
            vRes += v;
        }
        
        if(vRes.x == 0)
        {
            if(vRes.y == 0)
            {
                anim.Play("Idle");
            }
            else
            {
                anim.Play("Move");
            }
            if(vRes.y == speed)
            {
                Angle = -90;
            } else if(vRes.y == -speed)
            {
                Angle = 90;
            }
        } else if (vRes.x == speed)
        {
            if (vRes.y == 0)
            {
                Angle = 180;
            }
            else if (vRes.y == speed)
            {
                Angle = 225;
            }
            else
            {
                Angle = 135;
            }
        } else
        {
            if (vRes.y == 0)
            {
                Angle = 0;
            }
            else if (vRes.y == speed)
            {
                Angle = -45;
            }
            else
            {
                Angle = 45;
            }
        }
        if(vRes.x != 0 && vRes.y != 0)
        {
            vRes.x /= Mathf.Sqrt(2);
            vRes.y /= Mathf.Sqrt(2);
        }
        
        rb.MovePosition(vRes + rb.position);
        rb.MoveRotation(Angle);
    }


    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "var_1")
        {
            PerformMove();
        }
    }
}
