
//===================================================================================
//此代码由代码生成器自动生成      
//对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//===================================================================================
//作者:simple              
//创建时间：05-23-2019  
//版本1.0
//===================================================================================


using Maruko.Dependency;
using Maruko.Permission.Core.Application.Services.Permissions.DTO.MkoUser;
using Maruko.Permission.Core.Domain.Permissions;

namespace Maruko.Permission.Core.Application.Services.Permissions
{
    public interface IMkoUserService : ICrudAppServiceCore<MkoUser, MkoUserDto, SearchMkoUserDto>, IDependencyTransient
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        dynamic LoginIn(LoginInDto model);
    }
}