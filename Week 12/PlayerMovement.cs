using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite top;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    public Transform Weapon;
    public float weaponOffsetX = 3f;   
    public float weaponOffsetY = 3f;
    public GameObject bulletPrefab;          
    private Vector2 facing = Vector2.right;  

    void FaceLeft()
    {
        Weapon.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        Weapon.localPosition = new Vector3(-weaponOffsetX, -1f, 0f);
        Weapon.localRotation = Quaternion.Euler(0f, 0f, 0f);
        facing = Vector2.left;
    }

    void FaceRight()
    {
        Weapon.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        Weapon.localPosition = new Vector3(weaponOffsetX, -1f, 0f);
        Weapon.localRotation = Quaternion.Euler(0f, 0f, 0f);
        facing = Vector2.right;
    }

    void FaceUp()
    {
        Weapon.localRotation = Quaternion.Euler(0f, 0f, -90f);
        Weapon.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        Weapon.localPosition = new Vector3(0f, weaponOffsetY, 0f);
        facing = Vector2.up;
    }

    void FaceDown()
    {
        Weapon.localRotation = Quaternion.Euler(0f, 0f, 90f);
        Weapon.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        Weapon.localPosition = new Vector3(0f, -weaponOffsetY, 0f);
        facing = Vector2.down;
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Weapon.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().direction = facing;
    }

    void Update()
    {
        Movement();

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = left;
            FaceLeft();
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = right;
            FaceRight();
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = top;
            FaceUp();
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = down;
            FaceDown();
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
