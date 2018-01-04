using System.Web.Http;

namespace Stormancer.Server.AdminApi
{
    public interface IAdminWebApiConfig
    {
        void Configure(HttpConfiguration config);
    }
}
