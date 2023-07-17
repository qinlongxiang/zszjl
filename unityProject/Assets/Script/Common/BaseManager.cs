/******************************************************************************
* @file        BaseManager.cs
* @brief       管理器基类
* @version     1.0
* @author      qinlongxiang
* @date        2022.07.12
*
******************************************************************************/

namespace Zszjl.Common
{
    #region 类
    /// <summary>
    /// 管理器基类
    /// </summary>
    /// <typeparam name="T">管理器类型</typeparam>
    public abstract class BaseManager<T> : SingletonUnity<T>, IManager where T : BaseManager<T>, new()
    {
        #region 方法
        protected void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public abstract void Register();
        public abstract void Unregister();
        #endregion
    }
    #endregion
}
