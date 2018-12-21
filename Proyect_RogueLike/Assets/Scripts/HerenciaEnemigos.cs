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

    public class HerenciaEnemigos : MonoBehaviour
    {
        public AIDestinationSetter Target;
        public GameObject refPlayer;
        public Transform compPlayer;
        public cañon vida_player;
        public GameObject refplayer2;

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
