﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;
using WebApiClientCore.Attributes;

namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Interfaces
{
    /// <summary>
    /// 用户信息接口API
    /// </summary>
    public interface IUserInfoApi : IBiliBiliApi
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpGet("/x/web-interface/nav")]
        Task<BiliApiResponse<UserInfo>> LoginByCookie();
    }
}
