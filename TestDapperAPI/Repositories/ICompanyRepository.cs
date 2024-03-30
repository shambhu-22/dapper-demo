﻿using TestDapperAPI.Models;

namespace TestDapperAPI.Repositories
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
    }
}
