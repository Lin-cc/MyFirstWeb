﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MyFirstWeb.Authorization;
using MyFirstWeb.MultiTenancy;

namespace MyFirstWeb.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MyFirstWebControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}