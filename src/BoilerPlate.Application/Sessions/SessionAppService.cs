﻿using System.Threading.Tasks;
using Abp.Auditing;
using Abp.AutoMapper;
using Abp.ObjectMapping;
using BoilerPlate.Sessions.Dto;

namespace BoilerPlate.Sessions
{
    public class SessionAppService : BoilerPlateAppServiceBase, ISessionAppService
    {
        private readonly IObjectMapper _objectMapper;

        public SessionAppService(IObjectMapper objectMapper)
        {
            _objectMapper = objectMapper;
        }

        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput();

            if (AbpSession.UserId.HasValue)
            {
                output.User = _objectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = _objectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            return output;
        }
    }
}