﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service;
using SlnErp102.Core.Service.Infos.Hospitals;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Infos.Hospitals
{
    public class HospitalService:Service<Hospital>,IHospitalService
    {
        public HospitalService(IUnitOfWork unitOfWork, IRepository<Hospital> repository) : base(unitOfWork, repository)
        {
        }
    }
}