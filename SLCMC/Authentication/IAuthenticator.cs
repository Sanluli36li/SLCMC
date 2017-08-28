﻿namespace SLCMC.Authentication
{
    /// <summary>
    /// 验证器接口
    /// </summary>
    public interface IAuthenticator
    {
        /// <summary>
        /// 获取玩家信息
        /// </summary>
        /// <returns>玩家信息</returns>
        AuthenticationInfo Auth();

        /// <summary>
        /// 验证器名称
        /// </summary>
        string Type { get; }
    }
}
