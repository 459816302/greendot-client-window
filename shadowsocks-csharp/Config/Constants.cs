using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowSocks.Config
{
    class Constants
    {
        //DES key
        public static string DES_KEY = "MCMURPHY";

        //网站根目录
        public static string DEFAULT_SEVER_ROOT = "http://www.greenuuu.com/";

        //用户注册链接
        public static string USER_REGISTER_URI = "user/register";

        //用户找回密码链接
        public static string USER_FINDPWD_URI = "user/findpwd";

        //用户个人中心链接
        public static string USER_CENTER_URI = "user/index";

        //用户充值链接
        public static string RECHARGE_URI = "recharge/index";

        //用户登录接口
        public static string USER_LOGIN_API = "api/user/login";

        //用户注销接口
        public static string USER_LOGOUT_API = "api/user/logout";

        //用户信息接口
        public static string USER_INFO_API = "api/user/getUserInfo";

        //服务列表接口
        public static string SERVER_LIST_API = "api/server/lists";

        //服务器连接接口
        public static string SERVER_CONNECT_API = "api/server/connect";
        
        //服务器断开连接接口
        public static string SERVER_DISCONNECT_API = "api/server/disconnect";

        //更新检测接口
        public static string UPDATE_CHECK_API = "api/update/check";

        //应用配置接口
        public static string APP_CONFIG_API = "api/index/config";

        //PAC更新链接
        public static string PAC_UPDATE_URI = "https://raw.githubusercontent.com/gfwlist/gfwlist/master/gfwlist.txt";
    }
}
