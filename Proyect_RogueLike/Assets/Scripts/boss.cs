using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace Pathfinding
{
    using Pathfinding.Util;

    [RequireComponent(typeof(Seeker))]
    [AddComponentMenu("Pathfinding/AI/AILerp (2D,3D)")]
    [HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_lerp.php")]

    public class boss : HerenciaEnemigos
    {
        public Transform see;
        public Transform seeDead;
        //AIDestinationSetter Target;
        //GameObject refPlayer;
        //Transform compPlayer;
        public float life_boss = 1;
       // public GameObject enemy1, enemy2, enemy3;
        public Slider slider_boss;
        public GameObject escudito;
        void Start()
        {
                Target = GetComponent<AIDestinationSetter>();
                refPlayer = GameObject.FindGameObjectWithTag("Player");
            //slider_boss = GameObject.Find("Vida_Boss");
            //slider_boss.SetActive(true);
            //GameObject text = GameObject.Find("VidaBoss");
            //Text txt = text.GetComponent<Text>();
            //txt.enabled = true;

            
        }


        void Update()
        {
            if (refPlayer != null)
            {
                if (GameObject.Find("player/See") != null)
                {
                    see = GameObject.Find("player/See").GetComponent<Transform>();
                }
                
                compPlayer = refPlayer.GetComponent<Transform>();
                Target.target = compPlayer;
                transform.rotation = Quaternion.LookRotation(see.transform.position, Vector3.up);
            }
            if (GameObject.Find("player/See") == null)
            {
                seeDead = GameObject.Find("SeeDead").GetComponent<Transform>();
                see = seeDead;
                transform.rotation = Quaternion.LookRotation(see.transform.position, Vector3.up);
            }
            slider_boss.value = life_boss;

            if (life_boss <= 0.4f)
            {
                escudito.SetActive(true);
            }
        }

        void OnTriggerEnter(Collider col)//SI CHOCA CON LA BALA SE DESTRUYE EL ENEMIGO
        {
            if (col.tag.Equals("Bala"))
            {
                life_boss = life_boss - 0.05f;
                //sSpawnSelector();
                if (life_boss <=0)
                {
                    slider_boss.value = life_boss;
                    Destroy(gameObject);

                }
            }
        }


        /*void SpawnSelector()
        {
            int rand = Random.Range(0, 3);

            switch (rand)
            {
                case 0:
                    Instantiate(enemy1); 
                    break;
                case 1:
                    Instantiate(enemy2);
                    break;
                case 2:
                    Instantiate(enemy3);
                    break;

            }
        }*/
    }
}
