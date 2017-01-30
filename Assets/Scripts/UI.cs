using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    [SerializeField]
    private Image currentSpeedBar;
    [SerializeField]
    private Image currentHealthBar;
    [SerializeField]
    private Button respawn;

    public static float health;

    private float currentSpeed = 100f;
    private float maxCurrentSpeed = 100f;

	// Use this for initialization
	void Start () {
        //UpdateSpeedBar();
        health = 1f;
        respawn.gameObject.SetActive(false);
	}
	
    void Update()
    {
        currentSpeedBar.rectTransform.localScale = new Vector3((SpaceShipMovement.speed / 100), 1, 1);
        currentHealthBar.rectTransform.localScale = new Vector3(health, 1, 1);
        //currentSpeedBar.fillAmount = (SpaceShipMovement.speed / 100);
        //Debug.Log("fill: " + (SpaceShipMovement.speed / 100));
    }

	// Update is called once per frame
	/*private void UpdateSpeedBar () {
        float ratio = currentSpeed / maxCurrentSpeed;
        currentSpeedBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
	}

    private void DecreaseSpeed(float decrease)
    {
        //currentSpeed -= decrease;
        if (SpaceShipMovement.speed < 50)
            {
                currentSpeed = 0;
                Debug.Log("slow");
            }

        UpdateSpeedBar();
    }

    private void IncreaseSpeed(float increase)
    {
        //currentSpeed += increase;
        if(SpaceShipMovement.speed > SpaceShipMovement.maxSpeed)
        {
            currentSpeed = maxCurrentSpeed;
            Debug.Log("fast");
        }

        UpdateSpeedBar();
    }
    */

    public void Respawn()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
