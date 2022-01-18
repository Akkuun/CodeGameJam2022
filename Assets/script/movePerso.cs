using UnityEngine;

public class MovePerso : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 dir;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {if(Input.GetKeyDown(KeyCode.D)){
        dir.x = 1;
        }
         if(Input.GetKeyUp(KeyCode.D)){
            dir.x=0;
        }
         if(Input.GetKeyDown(KeyCode.Q)){
             dir.x=-1;
         }  if(Input.GetKeyUp(KeyCode.Q)){
            dir.x=0;
        }
                if(Input.GetKeyDown(KeyCode.Z)){
                    dir.y=1;
                }  if(Input.GetKeyUp(KeyCode.Z)){
            dir.y=0;
        }
                if(Input.GetKeyDown(KeyCode.
                S)){
                     dir.y = -1;
                }  if(Input.GetKeyUp(KeyCode.S)){
            dir.y=0;
        }
        rb.MovePosition(rb.position + dir * moveSpeed * Time.fixedDeltaTime);
    }
}
