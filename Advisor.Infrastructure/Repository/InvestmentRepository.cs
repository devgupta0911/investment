﻿using Advisor.Core.Domain.DTOs;
using Advisor.Core.Domain.Models;
using Advisor.Core.Interfaces.Repositories;
using Advisor.Infrastructure.Data;
using Microsoft.AspNetCore.Http;

namespace Advisor.Infrastructure.Repository
{
    public class InvestmentRepository : IInvestmentRepository
    {
        private readonly AdvisorDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public InvestmentRepository(AdvisorDbContext context, IHttpContextAccessor httpContext)
        {
            _context=context;
            _httpContext = httpContext;
        }
        public InvestmentDTO CreateInvestment(InvestmentDTO request,string email)
        {
            var advisor = _context.Users.First(X => X.Email == email);

            InvestmentStrategy strategy = new InvestmentStrategy();
            InvestmentType type=new InvestmentType();
            InvestorInfo info=new InvestorInfo();
            info.UserID=request.UserID;
            info.InvestmentName=request.InvestmentName;
            info.Active=request.Active;
            info.CreatedDate=DateTime.Now;
            info.ModifiedBy = advisor.AdvisorID;
            info.ModifiedDate=DateTime.Now;
            info.DeletedFlag = 0;
            _context.InvestorInfos.Add(info);
            _context.SaveChanges();

            type.InvestmentTypeName=request.InvestmentTypeName;
            type.CreatedDate=DateTime.Now;
            type.ModifiedDate=DateTime.Now;
            type.ModifiedBy=advisor.AdvisorID;
            type.DeletedFlag= 0;
            _context.InvestmentTypes.Add(type);
            _context.SaveChanges();

            InvestmentType type1 = _context.InvestmentTypes.First(x=>x.InvestmentTypeName==request.InvestmentTypeName);
            InvestorInfo info1 = _context.InvestorInfos.First(s => s.UserID == request.UserID);
            strategy.ModifiedDate=DateTime.Now;
            strategy.DeletedFlag= 0;
            strategy.ModifiedBy= advisor.AdvisorID;
            strategy.InvestmentAmount=request.InvestmentAmount;
            strategy.ModelAPLID=request.ModelAPLID;
            strategy.AccountID=request.AccountID;
            strategy.StrategyName=request.StrategyName;
            strategy.InvestmentTypeID = type1.InvestmentTypeID;
            strategy.InvestorInfoID=info1.InvestorInfoID;
            _context.InvestmentStrategies.Add(strategy);
            _context.SaveChanges();
            return request;
            
        }

        public InvestmentDTO GetInvestment(InvestmentDTO request, string email)
        {
            var advisor = _context.Users.First(x => x.Email == email);
            if (advisor is null)
                return null;
            InvestorInfo info = new InvestorInfo();
            info.UserID = request.UserID;
            info.InvestmentName = request.InvestmentName;
            info.Active = request.Active;
            info.CreatedDate = DateTime.Now;
            info.ModifiedBy = advisor.AdvisorID;
            info.ModifiedDate = DateTime.Now;
            info.DeletedFlag = 0;
            _context.InvestorInfos.Add(info);
            _context.SaveChanges();

            InvestmentType type = new InvestmentType();
            type.InvestmentTypeName = request.InvestmentTypeName;
            type.CreatedDate = DateTime.Now;
            type.ModifiedDate = DateTime.Now;
            type.ModifiedBy = advisor.AdvisorID;
            type.DeletedFlag = 0;
            _context.InvestmentTypes.Add(type);
            _context.SaveChanges();

            InvestmentStrategy strategy = new InvestmentStrategy();
            InvestmentType type1 = _context.InvestmentTypes.First(x => x.InvestmentTypeName == request.InvestmentTypeName);
            InvestorInfo info1 = _context.InvestorInfos.First(s => s.UserID == request.UserID);
            strategy.ModifiedDate = DateTime.Now;
            strategy.DeletedFlag = 0;
            strategy.ModifiedBy = advisor.AdvisorID;
            strategy.InvestmentAmount = request.InvestmentAmount;
            strategy.ModelAPLID = request.ModelAPLID;
            strategy.AccountID = request.AccountID;
            strategy.StrategyName = request.StrategyName;
            strategy.InvestmentTypeID = type1.InvestmentTypeID;
            strategy.InvestorInfoID = info1.InvestorInfoID;
            _context.InvestmentStrategies.Add(strategy);
            _context.SaveChanges();
            return request;
            //throw new NotImplementedException();
        }

        public InvestmentDTO UpdateInvestment(InvestmentDTO request, string email)
        {
            var advisor = _context.Users.First(x => x.Email == email);
            if (advisor is null)
                return null;
            InvestorInfo info = new InvestorInfo();
            info.UserID = request.UserID;
            info.InvestmentName = request.InvestmentName;
            info.Active = request.Active;
            info.CreatedDate = DateTime.Now;
            info.ModifiedBy = advisor.AdvisorID;
            info.ModifiedDate = DateTime.Now;
            info.DeletedFlag = 0;
            _context.InvestorInfos.Add(info);
            _context.SaveChanges();

            InvestmentType type = new InvestmentType();
            type.InvestmentTypeName = request.InvestmentTypeName;
            type.CreatedDate = DateTime.Now;
            type.ModifiedDate = DateTime.Now;
            type.ModifiedBy = advisor.AdvisorID;
            type.DeletedFlag = 0;
            _context.InvestmentTypes.Add(type);
            _context.SaveChanges();

            InvestmentStrategy strategy = new InvestmentStrategy();
            InvestmentType type1 = _context.InvestmentTypes.First(x => x.InvestmentTypeName == request.InvestmentTypeName);
            InvestorInfo info1 = _context.InvestorInfos.First(s => s.UserID == request.UserID);
            strategy.ModifiedDate = DateTime.Now;
            strategy.DeletedFlag = 0;
            strategy.ModifiedBy = advisor.AdvisorID;
            strategy.InvestmentAmount = request.InvestmentAmount;
            strategy.ModelAPLID = request.ModelAPLID;
            strategy.AccountID = request.AccountID;
            strategy.StrategyName = request.StrategyName;
            strategy.InvestmentTypeID = type1.InvestmentTypeID;
            strategy.InvestorInfoID = info1.InvestorInfoID;
            _context.InvestmentStrategies.Add(strategy);
            _context.SaveChanges();
            return request;
            //throw new NotImplementedException();
        }
    }
}
