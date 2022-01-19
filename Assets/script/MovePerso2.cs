using UnityEngine;

public class MovePerso2 : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 dir;

    Vector2 lookDirection = new Vector2(1, 0);
    Animator animator;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.RightArrow)){
        dir.x = 1;
        }
         if(Input.GetKeyUp(KeyCode.RightArrow)){
            dir.x=0;
        }
         if(Input.GetKeyDown(KeyCode.LeftArrow)){
             dir.x=-1;
         }  if(Input.GetKeyUp(KeyCode.LeftArrow)){
            dir.x=0;
        }
                if(Input.GetKeyDown(KeyCode.UpArrow)){
                    dir.y=1;
                }  if(Input.GetKeyUp(KeyCode.UpArrow)){
            dir.y=0;
        }
                if(Input.GetKeyDown(KeyCode.DownArrow)){
                     dir.y = -1;
                }  if(Input.GetKeyUp(KeyCode.DownArrow)){
            dir.y=0;
        }
        rb.MovePosition(rb.position + dir * moveSpeed * Time.fixedDeltaTime);

        Vector2 move = new Vector2(dir.x, dir.y);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("MoveX", lookDirection.x);
        animator.SetFloat("MoveY", lookDirection.y);
    }
}
