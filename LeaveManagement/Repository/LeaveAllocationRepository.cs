using LeaveManagement.Contracts;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repository
{
    public class LeaveAllocationRepository : RepositoryBase<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(ApplicationDbContext db) : base(db)
        {

        }
        //ApplicationDbContext Context
        //{
        //    get
        //    {
        //        return _context as ApplicationDbContext;
        //    }
        //}
    }
}
