using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    public float moveForce;

    public static PlayerCtrl Instance;

    public Rigidbody rb;

    public float JumpForce = 20f;

    public bool isClick;

    public bool isGameActive;

    private void Awake()
    {
        Instance = this;

        isClick = true;

        isGameActive = false;
    }
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        playerMoveDown();
    }

    private void OnCollisionStay(Collision other)
    {
        if (isGameActive == true)
        {
            playerMove();

            if (other.collider.gameObject.CompareTag("Yellow Ring") && isClick == true)
            {

                Destroy(other.transform.parent.gameObject);

                SoundManager.Instance.runSoundEffect();

                ScoreManager.Instance.scoreUP();

            }

            if (other.collider.gameObject.CompareTag("Black Ring") && isClick == true)
            {
                SceneManager.LoadScene(0);
            }

            if (other.collider.gameObject.CompareTag("Finish Point"))
            {
                GUIManager.Instance.TapToNextLv.gameObject.SetActive(true);

                Time.timeScale = 0;

                SoundManager.Instance.levelUpMusic();

                Debug.Log("Next Level");
            }
        }
    }

    public void playerMove()
    {
        if (isGameActive == true)
        {
            if (isClick == false)
            {
                rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            }
        }
        
    }

    public void playerMoveDown()
    {
        if (isGameActive == true)
        {
            if (Input.GetButton("Fire1"))
            {
                isClick = true;

                

                rb.velocity = new Vector3(0, -2, 0) * moveForce;
            }
            else
            {
                isClick = false;
            }
        }
    }
}
