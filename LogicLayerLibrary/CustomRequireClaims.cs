using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerLibrary
{
    namespace LogicLayerLibrary
    {
        public class CustomRequireClaim : IAuthorizationRequirement
        {
            public CustomRequireClaim(string claimType)
            {
                ClaimType = claimType;
            }
            public string ClaimType { get; }
        }

        public class CustomRequireClaimHandler : AuthorizationHandler<CustomRequireClaim>
        {
            protected override Task HandleRequirementAsync(
                AuthorizationHandlerContext context,
                CustomRequireClaim requirements)
            {
                var hasClaim = context.User.Claims.Any(x => x.Type == requirements.ClaimType);
                if (hasClaim)
                {
                    context.Succeed(requirements);
                }

                return Task.CompletedTask;
            }
        }

        public static class AuthorizationPolicyBuilderExtensions
        {
            public static AuthorizationPolicyBuilder RequireCustomClaim(
                this AuthorizationPolicyBuilder builder,
                string claimType)
            {
                builder.AddRequirements(new CustomRequireClaim(claimType));
                return builder;
            }
        }
    }

}
