using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Zszjl.World;

namespace Zszjl.Common
{

    public class WorldManager : BaseManager<WorldManager>, IWorldManager
    {
        private Dictionary<string, Map> mapDict;
        /// <summary>
        /// RegisterÊµÀý
        /// </summary>
        public override void Register()
        { }

        /// <summary>
        /// UnregisterÊµÀý
        /// </summary>
		public override void Unregister()
        {  }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

