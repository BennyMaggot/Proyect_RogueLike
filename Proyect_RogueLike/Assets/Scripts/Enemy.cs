using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Pathfinding
{
    using Pathfinding.Util;

    [RequireComponent(typeof(Seeker))]
    [AddComponentMenu("Pathfinding/AI/AILerp (2D,3D)")]
    [HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_lerp.php")]

    public class Enemy : HerenciaEnemigos
    {
        //AIDestinationSetter Target;
        //GameObject refPlayer;
        //Transform compPlayer;

        // Use this for initialization
        //public Vector3 mitransform;
        void Start()
        {
            Target = GetComponent<AIDestinationSetter>();
            refPlayer = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            compPlayer = refPlayer.GetComponent<Transform>();
            Target.target = compPlayer;
            
        }

        void OnTriggerEnter(Collider col)//SI CHOCA CON LA BALA SE DESTRUYE EL ENEMIGO
        {
            if (col.tag.Equals("Bala"))
            {
                mitransform = gameObject.transform.position;
                Instantiate(pariculas1,mitransform,Quaternion.identity);
                Destroy(gameObject);
            }
            if (col.tag.Equals("invencible"))
            {
                GameObject.Find("GameController").GetComponent<GameController>().Score++;
                Debug.Log("SCORE ACTUAL: " + GameObject.Find("GameController").GetComponent<GameController>().Score);
                mitransform = gameObject.transform.position;
                Instantiate(pariculas1, mitransform, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
