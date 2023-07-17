/******************************************************************************
* @file        IManager.cs
* @brief       管理器相关接口、枚举等的定义
* @version     1.0
* @author      qinlongxiang
* @date        2023.07.12
*
******************************************************************************/

namespace Zszjl.Common
{
    #region 接口
    /// <summary>
    /// 管理器接口
    /// </summary>
    public interface IManager
    {
        #region 方法
        /// <summary>
        /// 注册管理器
        /// </summary>
        void Register();
        /// <summary>
        /// 注销管理器
        /// </summary>
        void Unregister();
        #endregion
    }
    #endregion
}