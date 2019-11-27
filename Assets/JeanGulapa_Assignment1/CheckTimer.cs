using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CheckTimer : MonoBehaviour
    {
        private Text displayTxt;
        private float timeLeft = 40.0f;
        // Start is called before the first frame update
        void Start()
        {
            displayTxt = GetComponentInChildren<Text>(true);
        }

        // Update is called once per frame
        void Update()
        {

            timeLeft -= Time.deltaTime;

            if (timeLeft < 0 && ScoreMgr.instance.score >= 20 || ScoreMgr.instance.score >= 20)
            {
                SpecialWinLoseMusic.instance.PlayWinSfx();
                displayTxt.text = "You win the game!";
                Destroy(GameObject.FindGameObjectWithTag("Game").GetComponent<BulletSpawnLogic>());

            } else if (timeLeft < 0 && ScoreMgr.instance.score != 20)

            {
                SpecialWinLoseMusic.instance.PlayLoseSfx();
                displayTxt.text = "You lose the game!";
                Destroy(GameObject.FindGameObjectWithTag("Game").GetComponent<BulletSpawnLogic>());
            }
            else
            {
                displayTxt.text = $"Time: {timeLeft:F2}";
            }
        }
    }
}
