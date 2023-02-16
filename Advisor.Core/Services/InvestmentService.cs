﻿using Advisor.Core.Domain.DTOs;
using Advisor.Core.Interfaces.Repositories;
using Advisor.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor.Core.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly IInvestmentRepository _repository;

        public InvestmentService(IInvestmentRepository repository)
        {
            _repository = repository;
        }
        public Task<InvestmentDTO> CreateInvestment(InvestmentDTO request,string email)
        {
            var res = _repository.CreateInvestment(request,email);
            return Task.FromResult(res);
        }

        public Task<InvestmentDTO> GetInvestment(InvestmentDTO request,string email)
        {
            return Task.FromResult(_repository.GetInvestment(request,email));
            //throw new NotImplementedException();
        }

        public Task<InvestmentDTO> UpdateInvestment(InvestmentDTO request, string email)
        {
            return Task.FromResult(_repository.UpdateInvestment(request, email));
            //throw new NotImplementedException();
        }
    }
}
