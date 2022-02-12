﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Repository.Infos.Hospitals;

namespace SlnErp102.Data.Repository.Infos.Hospitals
{
    public class HospitalRepository:Repository<Hospital>,IHospitalRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public HospitalRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
