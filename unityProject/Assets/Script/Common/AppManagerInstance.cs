using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;

namespace Zszjl.Common
{
    public class AppManager : SingletonUnity<AppManager>, IAppManager
    {
        private void Awake()
        {
            RegisterManagers();
        }

        private void OnApplicationQuit()
        {
            UnregisterManageers();
        }

        public void RegisterManagers()
        {
            //WorldManager.Instance.Register();
        }

        public void UnregisterManageers()
        {
            //WorldManager.Instance.Unregister();
        }

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

