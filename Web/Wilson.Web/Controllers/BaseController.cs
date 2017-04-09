﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wilson.Companies.Data.DataAccess;
using Wilson.Scheduler.Data.DataAccess;

namespace Wilson.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public BaseController(ICompanyWorkData companyWorkData, ISchedulerWorkData schedulerWorkData, IMapper mapper)
        {
            this.CompanyWorkData = companyWorkData;
            this.SchedulerWorkData = schedulerWorkData;
            this.Mapper = mapper;
        }

        public ICompanyWorkData CompanyWorkData { get; set; }

        public ISchedulerWorkData SchedulerWorkData { get; set; }

        public IMapper Mapper { get; set; }
    }
}