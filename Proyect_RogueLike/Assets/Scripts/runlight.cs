using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pathfinding.Util;


namespace Pathfinding
{
    using Pathfinding.Util;

    [RequireComponent(typeof(Seeker))]
    [AddComponentMenu("Pathfinding/AI/AILerp (2D,3D)")]
    [HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_lerp.php")]

    public class runlight : HerenciaEnemigos
    {
        public AILerp scrip_lerp;

        //AIDestinationSetter Target;
        //GameObject refPlayer;
        //Transform compPlayer;

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
                Destroy(gameObject);
            }
            if (col.tag.Equals("luz"))
            {
                scrip_lerp.canMove = true;
                scrip_lerp.speed = 8;
            }
        }
        private void OnTriggerExit(Collider col)
        {
            if (col.tag.Equals("luz"))
            {
                scrip_lerp.canMove = false;
            }
        }
    }
}
