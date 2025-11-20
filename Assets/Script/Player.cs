 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public CameraShake cameraShake;
    public UIManager uiManager;
    public SoundManager soundManager;
    public PauseMenu pauseMenu;

    public GameObject cam;
    private Rigidbody rb;

    private Touch touch;
    [Range(20, 40)]
    public int speedModifier;
    public int forwardSpeed;

    public GameObject vectorBack;
    public GameObject vectorForward;
    

    public bool speedBallForward = false;
    public bool firstTouchControl = false;
    private int soundLimitCount;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        if (Variables.firstTouch == 1 && speedBallForward == false)
        {
            transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            vectorBack.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            vectorForward.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    if (firstTouchControl == false)
                    {
                        Variables.firstTouch = 1;
                        uiManager.FirstTouch();
                        firstTouchControl = true;
                    }
                }
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    rb.velocity = new Vector3(touch.deltaPosition.x * speedModifier * Time.deltaTime,
                                                    transform.position.y,
                                                    touch.deltaPosition.y * speedModifier * Time.deltaTime);

                    if (firstTouchControl == false)
                    {
                        Variables.firstTouch = 1;
                        uiManager.FirstTouch();
                        firstTouchControl = true;
                    }
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }

    public GameObject[] fractureItems;
    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Obstacles"))
        {
            cameraShake.CameraShakesCall();
            uiManager.StartCoroutine("WhiteEffect");
            uiManager.shieldIcon.SetActive(false);
            uiManager.timeIcon.SetActive(false);  
            pauseMenu.pauseIcon.SetActive(false);
            soundManager.BlowupSound();
            gameObject.transform.GetChild(0).gameObject.SetActive(false);

            if (PlayerPrefs.GetInt("Vibration") == 1)
            {
                Vibration.Vibrate(50);
            }
            else if (PlayerPrefs.GetInt("Vibration") == 2)
            {
                Debug.Log("Vibration Off");
            }

            foreach (GameObject item in fractureItems)
            {
                item.GetComponent<SphereCollider>().enabled = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
            } 
            StartCoroutine("TimeScaleControl");
        }

        if (hit.gameObject.CompareTag("Untagged"))
        {
            soundLimitCount++;
        }

        if (hit.gameObject.CompareTag("Untagged") && soundLimitCount % 5 == 0)
        {
            soundManager.ObjectHitSound();
        }
    }
    public IEnumerator TimeScaleControl()
    {
        speedBallForward = true;
        yield return new WaitForSeconds(0.4f);
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds(0.6f);
        uiManager.RestartButton();
        rb.velocity = Vector3.zero;
    }
}

