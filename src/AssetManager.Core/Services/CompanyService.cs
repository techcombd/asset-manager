﻿using AssetManager.Core.Entities;
using AssetManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Core.Services
{
   public class CompanyService: ICompanyService
    {
        private readonly IAsyncRepository<Company> _companyRepository;
        public CompanyService(IAsyncRepository<Company> repository)
        {
            this._companyRepository = repository;
        }

        public async Task<Company> AddCompany(Company entity)
        {
            throw new NotImplementedException();

        }

        public Task DeleteCompany(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> ListAllCompany()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompany(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
