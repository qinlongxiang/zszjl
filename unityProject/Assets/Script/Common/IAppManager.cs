namespace Zszjl.Common
{
    #region 接口
    /// <summary>
    /// 应用管理器接口
    /// </summary>
    public interface IAppManager
    {
        #region 方法
        /// <summary>
        /// 注册管理器
        /// </summary>
        void RegisterManagers();
        /// <summary>
        /// 注销管理器
        /// </summary>
        void UnregisterManageers();
        #endregion
    }
    #endregion
}
