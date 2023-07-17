/******************************************************************************
* @file        SingletonUnity.cs
* @brief       单例类，分为Unity及C#两种模式，需要实现单例模式的类需承继此两类中的一个
* @version     1.0
* @author      qinlongxiang
* @date        2023.07.12
*
*
******************************************************************************/

using UnityEngine;

namespace Zszjl.Common
{
    #region 类
    /// <summary>
    /// Unity单例基类，需挂载到游戏对象上的类继承此类
    /// </summary>
    /// <typeparam name="T">单例类型</typeparam>
    public class SingletonUnity<T> : MonoBehaviour where T : Component
    {
        #region 静态字段
        /// <summary>
        /// 实例
        /// </summary>
        private static T _instance = default(T);

        /// <summary>
        /// 是否已被销毁
        /// </summary>
        private static bool _destroyed = false;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static readonly object _locker = new object();
        #endregion

        #region 属性
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (!_destroyed)
                        {
                            /// 在场景中查找此类型的对象
                            _instance = (T)FindObjectOfType(typeof(T));

                            /// 若场景中没有此类对象，则创建一个以此类名为名称的对象
                            if (_instance == null)
                            {
                                GameObject instance = new GameObject(typeof(T).ToString());
                                _instance = instance.AddComponent<T>();
                            }
                        }
                    }
                }

                return _instance;
            }
        }

        private void OnDestroy()
        {
            _destroyed = true;
        }
        #endregion
    }

    /// <summary>
    /// C#单例基类，不需挂载到游戏对象上的类继承此类
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public class Singleton<T> where T : new()
    {
        #region 静态字段
        /// <summary>
        /// 实例
        /// </summary>
        private static T _instance = default(T);

        /// <summary>
        /// 线程锁
        /// </summary>
        private static readonly object _locker = new object();
        #endregion

        #region 属性
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        _instance = new T();
                    }
                }

                return _instance;
            }
        }
        #endregion
    }
    #endregion
}